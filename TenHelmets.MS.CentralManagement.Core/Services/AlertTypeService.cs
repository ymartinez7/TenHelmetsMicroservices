namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AlertTypeService : BaseService<AlertType>, IAlertTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alertTypeRepository"></param>
        public AlertTypeService(IAlertTypeRepository alertTypeRepository)
            : base(alertTypeRepository)
        {

        }
    }
}
