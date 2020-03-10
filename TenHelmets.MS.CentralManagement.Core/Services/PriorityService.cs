using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class PriorityService : BaseService<Priority>, IPriorityService
    {
        public PriorityService(IPriorityRepository priorityRepository)
            : base(priorityRepository)
        {

        }
    }
}
