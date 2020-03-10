using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class RolService : BaseService<Rol>, IRolService
    {
        public RolService(IRolRepository rolRepository)
            : base(rolRepository)
        {

        }
    }
}
