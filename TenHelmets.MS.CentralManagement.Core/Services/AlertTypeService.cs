using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class AlertTypeService : BaseService<AlertType>, IAlertTypeService
    {
        public AlertTypeService(IAlertTypeRepository alertTypeRepository)
            : base(alertTypeRepository)
        {

        }
    }
}
