using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ActivityTypeService : BaseService<ActivityType>, IActivityTypeService
    {
        public ActivityTypeService(IActivityTypeRepository activityTypeRepository)
            : base(activityTypeRepository)
        {

        }
    }
}
