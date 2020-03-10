using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TenHelmets.MS.Core.Services
{
    public class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> repository)
        {
            this._baseRepository = repository;
        }

        public T Add(T model)
        {
            return this._baseRepository.Add(model);
        }

        public IEnumerable<T> Add(IEnumerable<T> model)
        {
            return this._baseRepository.Add(model);
        }

        public async Task<T> AddAsync(T model)
        {
            return await this._baseRepository.AddAsync(model);
        }

        public async Task<IEnumerable<T>> AddAsync(IEnumerable<T> model)
        {
            return await this._baseRepository.AddAsync(model);
        }

        public void AddUoW(IEnumerable<T> model)
        {
            this._baseRepository.AddUoW(model);
        }

        public void Delete(int id)
        {
            this._baseRepository.Delete(id);
        }

        public void Delete(T model)
        {
            this._baseRepository.Delete(model);
        }

        public void Delete(IEnumerable<T> model)
        {
            this._baseRepository.Delete(model);
        }

        public async Task DeleteAsync(int id)
        {
            await this._baseRepository.DeleteAsync(id);
        }

        public async Task DeleteAsync(T model)
        {
            await this._baseRepository.DeleteAsync(model);
        }

        public async Task DeleteAsync(IEnumerable<T> model)
        {
            await this._baseRepository.DeleteAsync(model);
        }

        public void DeleteUoW(IEnumerable<T> model)
        {
            this._baseRepository.DeleteUoW(model);
        }

        public int Count()
        {
            return this._baseRepository.Count();
        }

        public T Find(int id)
        {
            return this._baseRepository.Find(id);
        }

        public T Find(T model)
        {
            return this._baseRepository.Find(model);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return this._baseRepository.Find(expression);
        }

        public async Task<T> FindAsync(int id)
        {
            return await this._baseRepository.FindAsync(id);
        }

        public async Task<T> FindAsync(T model)
        {
            return await this._baseRepository.FindAsync(model);
        }

        public async Task<IEnumerable<T>> FindAsync()
        {
            return await this._baseRepository.FindAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await this._baseRepository.FindAsync(expression);
        }

        public void Update(T model)
        {
            this._baseRepository.Update(model);
        }

        public void Update(IEnumerable<T> model)
        {
            this._baseRepository.Update(model);
        }

        public async Task UpdateAsync(T model)
        {
            await this._baseRepository.UpdateAsync(model);
        }

        public async Task UpdateAsync(IEnumerable<T> model)
        {
            await this._baseRepository.UpdateAsync(model);
        }

        public void UpdateUoW(IEnumerable<T> model)
        {
            this._baseRepository.UpdateUoW(model);
        }

        public void Dispose()
        {
            this._baseRepository.Dispose();
        }
    }
}
