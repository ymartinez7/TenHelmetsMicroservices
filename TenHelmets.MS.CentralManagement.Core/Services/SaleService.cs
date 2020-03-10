using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class SaleService : BaseService<Sale>, ISaleService
    {
        public SaleService(ISaleRepository saleRepository)
            : base(saleRepository)
        {

        }
    }
}
