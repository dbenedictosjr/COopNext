using COopNext.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Application.Interfaces;

public interface IUserService
{
    Task<UserDto> GetByIdAsync(Guid? id);
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task CreateAsync(UserDto userDto);
    Task UpdateAsync(UserDto userDto);
    Task DeleteAsync(Guid? id);
}