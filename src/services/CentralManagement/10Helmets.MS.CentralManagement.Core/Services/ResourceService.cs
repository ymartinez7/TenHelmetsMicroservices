namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

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
