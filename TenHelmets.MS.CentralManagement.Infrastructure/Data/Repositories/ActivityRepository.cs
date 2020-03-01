namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public ActivityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
