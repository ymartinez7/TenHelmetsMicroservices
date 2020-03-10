﻿using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class EspenseTypeService : BaseService<EspenseType>, IEspenseTypeService
    {
        public EspenseTypeService(IEspenseTypeRepository espenseTypeRepository)
            : base(espenseTypeRepository)
        {

        }
    }
}
