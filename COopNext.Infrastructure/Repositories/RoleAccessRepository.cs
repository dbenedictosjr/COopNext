using COopNext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Infrastructure.Repositories;

public class RoleAccessRepository : Repository<RoleAccess>
{
    public RoleAccessRepository(AppDbContext context)
        : base(context)
    {
    }
}
