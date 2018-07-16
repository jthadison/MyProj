using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProj.MultiTenancy.Dto;

namespace MyProj.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
