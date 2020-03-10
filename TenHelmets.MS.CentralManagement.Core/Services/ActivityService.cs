using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ActivityService : BaseService<Activity>, IActivityService
    {
        public ActivityService(IActivityRepository activityRepository)
            : base(activityRepository)
        {

        }
    }
}
