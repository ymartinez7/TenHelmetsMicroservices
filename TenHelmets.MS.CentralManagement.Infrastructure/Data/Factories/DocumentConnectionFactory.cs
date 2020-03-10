using TenHelmets.MS.Infrastructure.Data.Enums;
using TenHelmets.MS.Infrastructure.Data.Interfaces;

namespace TenHelmets.MS.Infrastructure.Data.Factories
{
    public static class DocumentConnectionFactory
    {
        public static IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection)
        {
            IDocumentConnection _conexionDocumento = null;
            switch (documentTypeConnection)
            {
                case DocumentTypeConnection.Xml:
                    break;
                case DocumentTypeConnection.Csv:
                    break;
                case DocumentTypeConnection.Txt:
                    break;
            }

            return _conexionDocumento;
        }
    }
}
