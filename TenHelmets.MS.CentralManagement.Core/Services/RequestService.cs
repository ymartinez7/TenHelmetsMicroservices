namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RequestService : BaseService<Request>, IRequestService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestRepository"></param>
        public RequestService(IRequestRepository requestRepository)
            : base(requestRepository)
        {

        }
    }
}
