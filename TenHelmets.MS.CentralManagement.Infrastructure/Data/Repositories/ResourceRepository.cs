using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Infrastructure.Data.Context;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public sealed class ResourceRepository : BaseRepository<Resource>, IResourceRepository
    {
        public ResourceRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
