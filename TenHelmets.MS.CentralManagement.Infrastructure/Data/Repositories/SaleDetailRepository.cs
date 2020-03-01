namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SaleDetailRepository : BaseRepository<SaleDetail>, ISaleDetailRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public SaleDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
