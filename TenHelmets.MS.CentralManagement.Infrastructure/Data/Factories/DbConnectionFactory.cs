using TenHelmets.MS.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.MS.Infrastructure.Data.Factories
{
    public static class DbConnectionFactory
    {
        public static IDbConnection GetConnection(DbContext dbContext)
        {
            return null;
        }
    }
}
