namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ServiceOrderService : BaseService<ServiceOrder>, IServiceOrderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceOrderRepository"></param>
        public ServiceOrderService(IServiceOrderRepository serviceOrderRepository)
            : base(serviceOrderRepository)
        {

        }
    }
}
