namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ModelService : BaseService<Model>, IModelService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelRepository"></param>
        public ModelService(IModelRepository modelRepository)
            : base(modelRepository)
        {

        }
    }
}
