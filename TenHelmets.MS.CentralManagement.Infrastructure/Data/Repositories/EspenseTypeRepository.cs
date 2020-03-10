using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Infrastructure.Data.Context;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public sealed class EspenseTypeRepository : BaseRepository<EspenseType>, IEspenseTypeRepository
    {
        public EspenseTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
