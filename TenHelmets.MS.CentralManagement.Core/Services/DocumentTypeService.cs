using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class DocumentTypeService : BaseService<DocumentType>, IDocumentTypeService
    {
        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
            : base(documentTypeRepository)
        {

        }
    }
}
