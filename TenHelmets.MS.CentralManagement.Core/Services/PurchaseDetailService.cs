namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class PurchaseDetailService : BaseService<PurchaseDetail>, IPurchaseDetailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="purchaseDetailRepository"></param>
        public PurchaseDetailService(IPurchaseDetailRepository purchaseDetailRepository)
            : base(purchaseDetailRepository)
        {

        }
    }
}
