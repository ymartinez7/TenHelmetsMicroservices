namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SectorService : BaseService<Sector>, ISectorService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectorRepository"></param>
        public SectorService(ISectorRepository sectorRepository)
            : base(sectorRepository)
        {

        }
    }
}
