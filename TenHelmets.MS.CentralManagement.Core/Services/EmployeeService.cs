namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeRepository"></param>
        public EmployeeService(IEmployeeRepository employeeRepository)
            : base(employeeRepository)
        {

        }
    }
}
