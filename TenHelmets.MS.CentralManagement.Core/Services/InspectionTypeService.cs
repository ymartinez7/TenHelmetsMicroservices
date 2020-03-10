using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class InspectionTypeService : BaseService<InspectionType>, IInspectionTypeService
    {
        public InspectionTypeService(IInspectionTypeRepository inspectionTypeRepository)
            : base(inspectionTypeRepository)
        {

        }
    }
}
