namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class OrganizationService : BaseService<Organization>, IOrganizationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationRepository"></param>
        public OrganizationService(IOrganizationRepository organizationRepository)
            : base(organizationRepository)
        {

        }
    }
}
