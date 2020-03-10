using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ResourceService : BaseService<Resource>, IResourceService
    {
        public ResourceService(IResourceRepository resourceRepository)
            : base(resourceRepository)
        {

        }
    }
}
