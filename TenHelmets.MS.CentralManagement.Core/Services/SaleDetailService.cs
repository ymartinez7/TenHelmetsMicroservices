namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class SaleDetailService : BaseService<SaleDetail>, ISaleDetailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleDetailRepository"></param>
        public SaleDetailService(ISaleDetailRepository saleDetailRepository)
            : base(saleDetailRepository)
        {

        }
    }
}
