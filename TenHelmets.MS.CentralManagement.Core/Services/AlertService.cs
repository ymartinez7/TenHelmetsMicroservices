namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AlertService : BaseService<Alert>, IAlertService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alertRepository"></param>
        public AlertService(IAlertRepository alertRepository)
            : base(alertRepository)
        {

        }
    }
}
