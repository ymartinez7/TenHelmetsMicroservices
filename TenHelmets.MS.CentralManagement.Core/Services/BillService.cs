namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class BillService : BaseService<Bill>, IBillService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="billRepository"></param>
        public BillService(IBillRepository billRepository)
            : base(billRepository)
        {

        }
    }
}
