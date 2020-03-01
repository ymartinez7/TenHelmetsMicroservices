namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceService : BaseService<Resource>, IResourceService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceRepository"></param>
        public ResourceService(IResourceRepository resourceRepository)
            : base(resourceRepository)
        {

        }
    }
}
