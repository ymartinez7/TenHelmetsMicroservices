using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class RequestTypeService : BaseService<RequestType>, IRequestTypeService
    {
        public RequestTypeService(IRequestTypeRepository requestTypeRepository)
            : base(requestTypeRepository)
        {

        }
    }
}
