namespace TenHelmets.MS.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        int CommitTransaction();
        //Task<int> CommitTransactionAsync();
    }
}
