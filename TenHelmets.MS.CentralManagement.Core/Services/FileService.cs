namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class FileService : BaseService<File>, IFileService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileRepository"></param>
        public FileService(IFileRepository fileRepository)
            : base(fileRepository)
        {

        }
    }
}
