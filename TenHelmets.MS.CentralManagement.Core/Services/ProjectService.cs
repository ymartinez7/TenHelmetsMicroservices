namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProjectService : BaseService<Project>, IProjectService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectRepository"></param>
        public ProjectService(IProjectRepository projectRepository)
            : base(projectRepository)
        {

        }
    }
}
