namespace TenHelmets.MS.Infrastructure.Data.Interfaces
{
    using TenHelmets.MS.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 
    /// </summary>
    public interface IConnectionManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        IDbConnection GetDbConnection(DbContext dbContext);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentTypeConnection"></param>
        /// <returns></returns>
        IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceTypeConnection"></param>
        /// <returns></returns>
        IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection);
    }
}
