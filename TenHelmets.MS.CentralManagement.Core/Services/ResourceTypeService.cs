namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceTypeService : BaseService<ResourceType>, IResourceTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceTypeRepository"></param>
        public ResourceTypeService(IResourceTypeRepository resourceTypeRepository)
            : base(resourceTypeRepository)
        {

        }
    }
}
