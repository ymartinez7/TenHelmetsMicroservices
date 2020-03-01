namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PriorityService : BaseService<Priority>, IPriorityService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="priorityRepository"></param>
        public PriorityService(IPriorityRepository priorityRepository)
            : base(priorityRepository)
        {

        }
    }
}
