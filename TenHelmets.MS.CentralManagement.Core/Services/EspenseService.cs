namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EspenseService : BaseService<Espense>, IEspenseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="espenseRepository"></param>
        public EspenseService(IEspenseRepository espenseRepository)
            : base(espenseRepository)
        {

        }
    }
}
