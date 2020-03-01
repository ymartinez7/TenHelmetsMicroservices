namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PurchaseDetailRepository : BaseRepository<PurchaseDetail>, IPurchaseDetailRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public PurchaseDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
