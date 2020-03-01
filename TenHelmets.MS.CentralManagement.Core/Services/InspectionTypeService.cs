namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class InspectionTypeService : BaseService<InspectionType>, IInspectionTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inspectionTypeRepository"></param>
        public InspectionTypeService(IInspectionTypeRepository inspectionTypeRepository)
            : base(inspectionTypeRepository)
        {

        }
    }
}
