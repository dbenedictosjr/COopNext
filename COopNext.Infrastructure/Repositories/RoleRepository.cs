using COopNext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Infrastructure.Repositories;

internal class RoleRepository : Repository<Role>
{
    public RoleRepository(AppDbContext context)
        : base(context)
    {
    }
}
