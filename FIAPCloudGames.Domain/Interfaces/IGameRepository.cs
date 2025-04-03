using FIAPCloudGames.Domain.Entities;

namespace FIAPCloudGames.Domain.Interfaces
{
    public interface IGameRepository : IRepository<Game>
    {
        Task<Game> GetAsync(String Name);
    }
}
