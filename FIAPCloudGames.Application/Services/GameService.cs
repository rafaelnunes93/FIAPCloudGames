using FIAPCloudGames.Application.DTOs;
using FIAPCloudGames.Domain.Entities;
using FIAPCloudGames.Domain.Interfaces;

namespace FIAPCloudGames.Application.Services;

public class GameService
{
    private readonly IGameRepository _gameRepository;

    public GameService(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    public async Task<GameDTO> AddGameAsync(GameDTO dto)
    {
        var game = new Game(dto.Name, dto.Description, dto.Price, dto.Category);
        await _gameRepository.AddAsync(game);
        return new GameDTO
        {
            Name = game.Name,
            Description = game.Description,
            Price = game.Price,
            Category = game.Category
        };
    }

    public async Task<IEnumerable<GameDTO>> GetAllGamesAsync()
    {
        var games = await _gameRepository.GetAllAsync();
        return games.Select(game => new GameDTO
        {
            Name = game.Name,
            Description = game.Description,
            Price = game.Price
        }).ToList();
    }
}
