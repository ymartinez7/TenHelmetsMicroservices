namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProjectBudgetService : BaseService<ProjectBudget>, IProjectBudgetService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectBudgetRepository"></param>
        public ProjectBudgetService(IProjectBudgetRepository projectBudgetRepository)
            : base(projectBudgetRepository)
        {

        }
    }
}
