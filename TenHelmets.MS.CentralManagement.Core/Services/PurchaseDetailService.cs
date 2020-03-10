using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class PurchaseDetailService : BaseService<PurchaseDetail>, IPurchaseDetailService
    {
        public PurchaseDetailService(IPurchaseDetailRepository purchaseDetailRepository)
            : base(purchaseDetailRepository)
        {

        }
    }
}
