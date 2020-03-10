using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Infrastructure.Data.Context;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public sealed class OrganizationRepository : BaseRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
