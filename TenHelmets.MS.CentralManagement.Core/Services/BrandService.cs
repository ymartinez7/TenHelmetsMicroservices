using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class BrandService : BaseService<Brand>, IBrandService
    {
        public BrandService(IBrandRepository brandRepository)
            : base(brandRepository)
        {

        }
    }
}
