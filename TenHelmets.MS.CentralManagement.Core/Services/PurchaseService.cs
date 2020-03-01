namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class PurchaseService : BaseService<Purchase>, IPurchaseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="purchaseRepository"></param>
        public PurchaseService(IPurchaseRepository purchaseRepository)
            : base(purchaseRepository)
        {

        }
    }
}
