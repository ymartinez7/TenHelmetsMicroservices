namespace TenHelmets.MS.Infrastructure.Data.Factories
{
    using TenHelmets.MS.Infrastructure.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 
    /// </summary>
    public static class DbConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        public static IDbConnection GetConnection(DbContext dbContext)
        {
            return null;
        }
    }
}
