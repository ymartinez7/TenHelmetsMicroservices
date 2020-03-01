namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class InpectionService : BaseService<Inspection>, IInspectionService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inspectionRepository"></param>
        public InpectionService(IInspectionRepository inspectionRepository)
            : base(inspectionRepository)
        {

        }
    }
}
