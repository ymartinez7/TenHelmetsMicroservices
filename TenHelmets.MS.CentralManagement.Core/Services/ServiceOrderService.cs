using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ServiceOrderService : BaseService<ServiceOrder>, IServiceOrderService
    {
        public ServiceOrderService(IServiceOrderRepository serviceOrderRepository)
            : base(serviceOrderRepository)
        {

        }
    }
}
