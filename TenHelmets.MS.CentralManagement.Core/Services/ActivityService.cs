namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ActivityService : BaseService<Activity>, IActivityService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="activityRepository"></param>
        public ActivityService(IActivityRepository activityRepository)
            : base(activityRepository)
        {

        }
    }
}
