using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Infrastructure.Data.Context;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public sealed class PurchaseDetailRepository : BaseRepository<PurchaseDetail>, IPurchaseDetailRepository
    {
        public PurchaseDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
