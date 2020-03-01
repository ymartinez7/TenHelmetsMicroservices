namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class BrandService : BaseService<Brand>, IBrandService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="brandRepository"></param>
        public BrandService(IBrandRepository brandRepository)
            : base(brandRepository)
        {

        }
    }
}
