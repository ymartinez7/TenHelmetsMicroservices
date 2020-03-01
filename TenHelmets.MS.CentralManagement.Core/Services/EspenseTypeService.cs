namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EspenseTypeService : BaseService<EspenseType>, IEspenseTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="espenseTypeRepository"></param>
        public EspenseTypeService(IEspenseTypeRepository espenseTypeRepository)
            : base(espenseTypeRepository)
        {

        }
    }
}
