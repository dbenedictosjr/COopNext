using COopNext.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _context;
    private bool _disposed = false;

    public Repository(AppDbContext context) => _context = context;

    public virtual async Task<TEntity> GetByIdAsync(Guid? id) => await _context.Set<TEntity>().FindAsync(id);

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _context.Set<TEntity>().ToListAsync();

    public void Create(TEntity entity) => _context.Set<TEntity>().AddAsync(entity);

    public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

    public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);

    public void Detach(TEntity entity) => _context.Entry(entity).State = EntityState.Detached;

    public async Task SaveAsync() => await _context.SaveChangesAsync();

    public void Dispose()
    {
        if (!_disposed)
        {
            _context.Dispose();
            _disposed = true;
        }
    }
}