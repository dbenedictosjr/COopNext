using COopNext.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Application.Interfaces;

public interface IModuleService
{
    Task<ModuleDto> GetByIdAsync(Guid? id);
    Task<IEnumerable<ModuleDto>> GetAllAsync();
    Task CreateAsync(ModuleDto userDto);
    Task UpdateAsync(ModuleDto userDto);
    Task DeleteAsync(Guid? id);
}