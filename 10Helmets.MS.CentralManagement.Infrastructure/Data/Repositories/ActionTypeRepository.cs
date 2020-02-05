﻿namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ActionTypeRepository : BaseRepository<ActionType>, IActionTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public ActionTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
