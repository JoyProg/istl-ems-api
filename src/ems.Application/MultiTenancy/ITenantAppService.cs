using Abp.Application.Services;
using ems.MultiTenancy.Dto;

namespace ems.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

