using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class EspenseService : BaseService<Espense>, IEspenseService
    {
        public EspenseService(IEspenseRepository espenseRepository)
            : base(espenseRepository)
        {

        }
    }
}
