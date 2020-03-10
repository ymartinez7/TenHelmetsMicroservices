using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class ProviderService : BaseService<Provider>, IProviderService
    {
        public ProviderService(IProviderRepository providerRepository)
            : base(providerRepository)
        {

        }
    }
}
