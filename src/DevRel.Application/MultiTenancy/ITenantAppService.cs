using Abp.Application.Services;
using DevRel.MultiTenancy.Dto;

namespace DevRel.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

