namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class CalService : BaseService<Cal>, ICalService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calRepository"></param>
        public CalService(ICalRepository calRepository)
            : base(calRepository)
        {

        }
    }
}
