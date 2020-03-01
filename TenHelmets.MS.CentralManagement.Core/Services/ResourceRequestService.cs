namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceRequestService : BaseService<ResourceRequest>, IResourceRequestService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceRequestRepository"></param>
        public ResourceRequestService(IResourceRequestRepository resourceRequestRepository)
            : base(resourceRequestRepository)
        {

        }
    }
}
