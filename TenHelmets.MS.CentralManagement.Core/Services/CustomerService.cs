namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CustomerService : BaseService<Customer>, ICustomerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerRepository"></param>
        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {

        }
    }
}
