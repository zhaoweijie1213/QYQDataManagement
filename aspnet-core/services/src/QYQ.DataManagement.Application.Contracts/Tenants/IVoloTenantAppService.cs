using System.Threading.Tasks;
using QYQ.DataManagement.Extension.Customs.Dtos;
using QYQ.DataManagement.Tenants.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc.MultiTenancy;
using Volo.Abp.TenantManagement;

namespace QYQ.DataManagement.Tenants
{
    public interface IVoloTenantAppService : IApplicationService
    {
        Task<FindTenantResultDto> FindTenantByNameAsync(FindTenantByNameInput input);

        Task<PagedResultDto<TenantDto>> ListAsync(PagingTenantInput input);

        Task<TenantDto> CreateAsync(TenantCreateDto input);

        Task<TenantDto> UpdateAsync(UpdateTenantInput input);

        Task DeleteAsync(IdInput input);

        Task<string> GetDefaultConnectionStringAsync(IdInput input);

        Task UpdateDefaultConnectionStringAsync(UpdateConnectionStringInput input);

        Task DeleteDefaultConnectionStringAsync(IdInput input);
    }
}