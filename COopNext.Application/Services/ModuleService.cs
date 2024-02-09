using AutoMapper;
using COopNext.Application.DTOs;
using COopNext.Application.Interfaces;
using COopNext.Domain.Entities;
using COopNext.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Application.Services;

public class ModuleService:IModuleService
{
    private readonly IRepository<Module> _repository;
    private readonly IMapper _mapper;

    public ModuleService(IRepository<Module> moduleRepository, IMapper mapper)
    {
        _repository = moduleRepository;
        _mapper = mapper;
    }

    public async Task<ModuleDto> GetByIdAsync(Guid? id) => _mapper.Map<ModuleDto>(await _repository.GetByIdAsync(id));

    public async Task<IEnumerable<ModuleDto>> GetAllAsync() => _mapper.Map<IEnumerable<ModuleDto>>(await _repository.GetAllAsync());

    public async Task CreateAsync(ModuleDto moduleDto)
    {
        _repository.Create(_mapper.Map<Module>(moduleDto));
        await _repository.SaveAsync();
    }

    public async Task UpdateAsync(ModuleDto moduleDto)
    {
        _repository.Update(_mapper.Map<Module>(moduleDto));
        await _repository.SaveAsync();
    }

    public async Task DeleteAsync(Guid? id)
    {
        _repository.Delete(await _repository.GetByIdAsync(id));
        await _repository.SaveAsync();
    }
}
