using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Domain.Interfaces
{
    public interface IAuditable
    {
        Guid CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        Guid UpdatedBy { get; set; }

        DateTime UpdatedDate { get; set; }

        byte[] RowVersion { get; set; }
    }
}
