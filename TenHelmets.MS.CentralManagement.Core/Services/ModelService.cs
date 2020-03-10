using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ModelService : BaseService<Model>, IModelService
    {
        public ModelService(IModelRepository modelRepository)
            : base(modelRepository)
        {

        }
    }
}
