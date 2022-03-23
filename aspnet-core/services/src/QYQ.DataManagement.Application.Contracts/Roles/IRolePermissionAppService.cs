using System.Threading.Tasks;
using QYQ.DataManagement.Roles.Dtos;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.Roles
{
    public interface IRolePermissionAppService : IApplicationService
    {
        
        Task<PermissionOutput> GetPermissionAsync(GetPermissionInput input);

        Task UpdatePermissionAsync(UpdateRolePermissionsInput input);
    }
}