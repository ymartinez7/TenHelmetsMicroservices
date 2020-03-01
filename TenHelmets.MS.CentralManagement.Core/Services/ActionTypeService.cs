namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class ActionTypeService : BaseService<ActionType>, IActionTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionTypeRepository"></param>
        public ActionTypeService(IActionTypeRepository actionTypeRepository)
            : base(actionTypeRepository)
        {

        }
    }
}
