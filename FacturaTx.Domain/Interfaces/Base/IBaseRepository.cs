using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        // Métodos síncronos
        public ICollection<TEntity> GetAll();
        public ICollection<TEntity> GetAllAsNoTracking();
        public TEntity GetById(Guid id);
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);

        // Novos métodos assíncronos
        public Task<ICollection<TEntity>> GetAllAsync();
        public Task<ICollection<TEntity>> GetAllAsNoTrackingAsync();
        public Task<TEntity> GetByIdAsync(Guid id);
        public Task AddAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity);
        public Task DeleteAsync(TEntity entity);
    }
}
