namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class ProviderService : BaseService<Provider>, IProviderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerRepository"></param>
        public ProviderService(IProviderRepository providerRepository)
            : base(providerRepository)
        {

        }
    }
}
