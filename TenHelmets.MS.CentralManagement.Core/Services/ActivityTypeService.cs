namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ActivityTypeService : BaseService<ActivityType>, IActivityTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="activityTypeRepository"></param>
        public ActivityTypeService(IActivityTypeRepository activityTypeRepository)
            : base(activityTypeRepository)
        {

        }
    }
}
