namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RequestTypeService : BaseService<RequestType>, IRequestTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestTypeRepository"></param>
        public RequestTypeService(IRequestTypeRepository requestTypeRepository)
            : base(requestTypeRepository)
        {

        }
    }
}
