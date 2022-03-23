using System;
using System.Threading.Tasks;
using QYQ.DataManagement.Roles.Dtos;
using QYQ.DataManagement.Extension.Customs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace QYQ.DataManagement.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task<ListResultDto<IdentityRoleDto>> AllListAsync();

        Task<PagedResultDto<IdentityRoleDto>> ListAsync(PagingRoleListInput input);

        Task<IdentityRoleDto> CreateAsync(IdentityRoleCreateDto input);

        Task<IdentityRoleDto> UpdateAsync(UpdateRoleInput input);

        Task DeleteAsync(IdInput input);

    }
}