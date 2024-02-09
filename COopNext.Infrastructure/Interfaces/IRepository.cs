using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Infrastructure.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetByIdAsync(Guid? id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Detach(TEntity entity);
    Task SaveAsync();
    void Dispose();
}
