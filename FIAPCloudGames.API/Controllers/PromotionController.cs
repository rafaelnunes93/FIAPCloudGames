using FIAPCloudGames.Application.DTOs;
using FIAPCloudGames.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FIAPCloudGames.API.Controllers;

[Route("api/promotions")]
[ApiController]
public class PromotionController : ControllerBase
{
    private readonly PromotionService _promotionService;

    public PromotionController(PromotionService promotionService)
    {
        _promotionService = promotionService;
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    public async Task<IActionResult> AddPromotion([FromBody] PromotionDTO dto)
    {
        var promotion = await _promotionService.AddPromotionAsync(dto);
        return CreatedAtAction(nameof(GetAllPromotions), new { id = promotion.GameName }, promotion);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPromotions()
    {
        var promotions = await _promotionService.GetAllPromotionsAsync();
        return Ok(promotions);
    }
}
