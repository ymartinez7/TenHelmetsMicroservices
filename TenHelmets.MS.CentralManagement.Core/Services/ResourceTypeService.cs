using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ResourceTypeService : BaseService<ResourceType>, IResourceTypeService
    {
        public ResourceTypeService(IResourceTypeRepository resourceTypeRepository)
            : base(resourceTypeRepository)
        {

        }
    }
}
