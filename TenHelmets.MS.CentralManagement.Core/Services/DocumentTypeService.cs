namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class DocumentTypeService : BaseService<DocumentType>, IDocumentTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentTypeRepository"></param>
        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
            : base(documentTypeRepository)
        {

        }
    }
}
