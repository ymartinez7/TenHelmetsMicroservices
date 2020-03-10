using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class ActionTypeService : BaseService<ActionType>, IActionTypeService
    {
        public ActionTypeService(IActionTypeRepository actionTypeRepository)
            : base(actionTypeRepository)
        {

        }
    }
}
