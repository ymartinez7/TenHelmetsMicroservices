using TenHelmets.MS.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.MS.Infrastructure.Data.Interfaces
{
    public interface IConnectionManager
    {
        IDbConnection GetDbConnection(DbContext dbContext);
        IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection);
        IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection);
    }
}
