namespace TenHelmets.MS.Infrastructure.Data.Factories
{
    using TenHelmets.MS.Infrastructure.Data.Enums;
    using TenHelmets.MS.Infrastructure.Data.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public static class DocumentConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoDocumento"></param>
        /// <returns></returns>
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
