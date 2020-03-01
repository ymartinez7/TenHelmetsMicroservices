namespace TenHelmets.MS.Core.Interfaces.Repositories
{
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int CommitTransaction();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //Task<int> CommitTransactionAsync();
    }
}
