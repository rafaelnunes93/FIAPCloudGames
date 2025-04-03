using FIAPCloudGames.Application.DTOs;
using FIAPCloudGames.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FIAPCloudGames.API.Controllers;

[Route("api/games")]
[ApiController]
public class GameController : ControllerBase
{
    private readonly GameService _gameService;

    public GameController(GameService gameService)
    {
        _gameService = gameService;
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    public async Task<IActionResult> AddGame([FromBody] GameDTO dto)
    {
        var game = await _gameService.AddGameAsync(dto);
        return CreatedAtAction(nameof(GetAllGames), new { id = game.Name }, game);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllGames()
    {
        var games = await _gameService.GetAllGamesAsync();
        return Ok(games);
    }
}
