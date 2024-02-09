using COopNext.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }

    public Guid CurrentUserId { get; set; }

    //public DbSet<Item> Items { get; set; }

    public async Task<int> SaveChangesAsync()
    {
        try
        {
            UpdateAuditEntities();
            return await base.SaveChangesAsync();
        }
        catch
        {
            throw;
        }
    }

    public int Save()
    {
        try
        {
            UpdateAuditEntities();
            return base.SaveChanges();
        }
        catch
        {
            throw;
        }
    }

    private void UpdateAuditEntities()
    {
        var modifiedEntries = ChangeTracker.Entries()
            .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

        foreach (var entry in modifiedEntries)
        {
            var entity = (IAuditable)entry.Entity;
            DateTime now = DateTime.UtcNow;

            if (entry.State == EntityState.Added)
            {
                entity.CreatedDate = now;
                entity.CreatedBy = CurrentUserId;
            }
            else
            {
                base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            }

            entity.UpdatedDate = now;
            entity.UpdatedBy = CurrentUserId;
        }
    }
}
