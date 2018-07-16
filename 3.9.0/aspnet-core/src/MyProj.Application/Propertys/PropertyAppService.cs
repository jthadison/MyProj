using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProj.Propertys.Dto;

namespace MyProj.Propertys
{
    public class PropertyAppService : IPropertyAppService
    {

        private readonly IRepository<Property> _propertyRepository;

        public PropertyAppService(IRepository<Property> propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public async Task<ListResultDto<Property>> GetAllAsync(GetAllPropertiesInput input)
        {
            var properties = await _propertyRepository
                .GetAll()
                //.WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();
            return new ListResultDto<Property>(
                //ObjectMapper.Map<List<PropertyListDto>>(properties)
                properties
            );
        }
    }
}
