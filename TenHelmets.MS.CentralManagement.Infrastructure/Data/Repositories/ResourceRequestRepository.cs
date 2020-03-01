﻿namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceRequestRepository : BaseRepository<ResourceRequest>, IResourceRequestRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public ResourceRequestRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
