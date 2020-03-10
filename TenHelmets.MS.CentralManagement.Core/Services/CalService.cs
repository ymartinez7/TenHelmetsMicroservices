using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class CalService : BaseService<Cal>, ICalService
    {
        public CalService(ICalRepository calRepository)
            : base(calRepository)
        {

        }
    }
}
