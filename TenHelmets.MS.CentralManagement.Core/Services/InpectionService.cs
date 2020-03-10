using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class InpectionService : BaseService<Inspection>, IInspectionService
    {
        public InpectionService(IInspectionRepository inspectionRepository)
            : base(inspectionRepository)
        {

        }
    }
}
