using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class PurchaseService : BaseService<Purchase>, IPurchaseService
    {
        public PurchaseService(IPurchaseRepository purchaseRepository)
            : base(purchaseRepository)
        {

        }
    }
}
