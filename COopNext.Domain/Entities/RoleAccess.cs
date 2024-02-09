using COopNext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Domain.Entities
{
    public class RoleAccess:IAuditable
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid ModuleId { get; set; }
        public bool HasAccess { get; set; }
        public bool CanAdd { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanPrint { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
