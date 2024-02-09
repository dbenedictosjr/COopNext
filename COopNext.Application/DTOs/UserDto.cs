using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Application.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public DateTime Validity { get; set; }
    public bool IsLocked { get; set; }
    public Guid RoleId { get; set; }
    public byte[] RowVersion { get; set; }
}
