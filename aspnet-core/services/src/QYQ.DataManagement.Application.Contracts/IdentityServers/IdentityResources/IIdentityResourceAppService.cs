using System.Collections.Generic;
using System.Threading.Tasks;
using QYQ.DataManagement.IdentityServers.IdentityResources.Dtos;
using QYQ.DataManagement.Extension.Customs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.IdentityServers.IdentityResources
{
    public interface IIdentityResourceAppService : IApplicationService
    {
        /// <summary>
        /// 分页获取IdentityResource
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PagingIdentityResourceListOutput>> GetListAsync(
            PagingIdentityResourceListInput input);

        Task<List<PagingIdentityResourceListOutput>> GetAllAsync();

        /// <summary>
        /// 创建IdentityResource
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateAsync(CreateIdentityResourceInput input);

        /// <summary>
        /// 更新IdentityResource
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAsync(UpdateIdentityResourceInput input);

        /// <summary>
        /// 删除IdentityResource
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteAsync(IdInput input);
    }
}