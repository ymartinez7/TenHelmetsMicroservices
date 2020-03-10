using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class CustomerService : BaseService<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {

        }
    }
}
