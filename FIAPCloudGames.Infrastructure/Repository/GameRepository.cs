using FIAPCloudGames.Domain.Entities;
using FIAPCloudGames.Domain.Interfaces;
using FIAPCloudGames.Infrastructure.Persistence;

public class GameRepository : IGameRepository
{
    private readonly ApplicationDbContext _context;

    public GameRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task AddAsync(Game entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Game>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Game> GetAsync(Guid id)
    {
        return await _context.Games.FindAsync(id);
    }

    public Task<Game> GetAsync(string Name)
    {
        throw new NotImplementedException();
    }

    public Task<Game?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Game entity)
    {
        throw new NotImplementedException();
    }
}
