using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class UnitService : BaseService<Unit>, IUnitService
    {
        public UnitService(IUnitRepository unitRepository)
            : base(unitRepository)
        {

        }
    }
}
