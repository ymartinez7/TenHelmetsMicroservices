namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class SaleService : BaseService<Sale>, ISaleService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleRepository"></param>
        public SaleService(ISaleRepository saleRepository)
            : base(saleRepository)
        {

        }
    }
}
