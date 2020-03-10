﻿using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class ResourceRequestService : BaseService<ResourceRequest>, IResourceRequestService
    {
        public ResourceRequestService(IResourceRequestRepository resourceRequestRepository)
            : base(resourceRequestRepository)
        {

        }
    }
}
