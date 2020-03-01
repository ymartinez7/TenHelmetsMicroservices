namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RolService : BaseService<Rol>, IRolService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rolRepository"></param>
        public RolService(IRolRepository rolRepository)
            : base(rolRepository)
        {

        }
    }
}
