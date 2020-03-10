using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class OrganizationService : BaseService<Organization>, IOrganizationService
    {
        public OrganizationService(IOrganizationRepository organizationRepository)
            : base(organizationRepository)
        {

        }
    }
}
