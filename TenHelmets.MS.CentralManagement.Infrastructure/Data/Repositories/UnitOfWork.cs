using TenHelmets.MS.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.MS.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public void BeginTransaction()
        {
            //var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            //_context = contextManager.Context;
        }

        public int CommitTransaction()
        {
            //return _context.SaveChanges();
            return 1;
        }

        //public async Task<int> CommitTransactionAsync()
        //{
        //    return await _context.SaveChangesAsync();
        //}
    }
}
