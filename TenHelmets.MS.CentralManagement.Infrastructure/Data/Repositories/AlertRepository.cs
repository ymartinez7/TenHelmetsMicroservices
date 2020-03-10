using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Infrastructure.Data.Context;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public sealed class AlertRepository : BaseRepository<Alert>, IAlertRepository
    {
        public AlertRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
