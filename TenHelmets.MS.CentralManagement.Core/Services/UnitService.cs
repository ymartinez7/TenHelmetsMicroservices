namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class UnitService : BaseService<Unit>, IUnitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitRepository"></param>
        public UnitService(IUnitRepository unitRepository)
            : base(unitRepository)
        {

        }
    }
}
