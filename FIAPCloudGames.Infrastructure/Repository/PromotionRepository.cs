using FIAPCloudGames.Domain.Entities;
using FIAPCloudGames.Domain.Interfaces;
using FIAPCloudGames.Infrastructure.Persistence;

namespace FIAPCloudGames.Infrastructure.Repositories
{
    public class PromotionRepository : Repository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(ApplicationDbContext context) : base(context) { }

        // Você pode adicionar métodos específicos para manipulação de promoções, se necessário
    }
}
