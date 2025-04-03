using FIAPCloudGames.Application.DTOs;
using FIAPCloudGames.Domain.Entities;
using FIAPCloudGames.Domain.Interfaces;

namespace FIAPCloudGames.Application.Services;

public class PromotionService
{
    private readonly IPromotionRepository _promotionRepository;
    private readonly IGameRepository _gameRepository;

    public PromotionService(IPromotionRepository promotionRepository, IGameRepository gameRepository)
    {
        _promotionRepository = promotionRepository;
        _gameRepository = gameRepository;
    }

    public async Task<PromotionDTO> AddPromotionAsync(PromotionDTO dto)
    {
        var game = await _gameRepository.GetAsync(dto.GameName);
        if (game == null)
        {
            throw new Exception("Jogo não encontrado.");
        }

        var promotion = new Promotion(dto.DiscountPercentage,dto.StartDate, dto.ExpiryDate, game);
        await _promotionRepository.AddAsync(promotion);

        return new PromotionDTO
        {
            GameName = game.Name,
            DiscountPercentage = promotion.Discount,
            StartDate = dto.StartDate,
            ExpiryDate = promotion.EndDate
        };

        //Guid id, decimal discount, DateTime startDate, DateTime endDate, Game game
    }

    public async Task<IEnumerable<PromotionDTO>> GetAllPromotionsAsync()
    {
        var promotions = await _promotionRepository.GetAllAsync();
        return promotions.Select(p => new PromotionDTO
        {
            GameName = p.Game.Name,
            DiscountPercentage = p.Discount,
            ExpiryDate = p.EndDate
        }).ToList();
    }
}
