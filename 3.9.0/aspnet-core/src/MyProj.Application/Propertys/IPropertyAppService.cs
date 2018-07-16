using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProj.Propertys.Dto;

namespace MyProj.Propertys
{
    public interface IPropertyAppService : IApplicationService
    {
        Task<ListResultDto<Property>> GetAllAsync(GetAllPropertiesInput input);
    }
}