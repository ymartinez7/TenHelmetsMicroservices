﻿using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Infrastructure.Data.Context;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public sealed class ResourceTypeRepository : BaseRepository<ResourceType>, IResourceTypeRepository
    {
        public ResourceTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
