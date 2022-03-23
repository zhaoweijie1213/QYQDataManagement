using System.Collections.Generic;
using System.Threading.Tasks;
using QYQ.DataManagement.IdentityServers.ApiScopes.Dtos;
using QYQ.DataManagement.Extension.Customs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.IdentityServers.ApiScopes
{
    public interface IApiScopeAppService : IApplicationService
    {
        Task<PagedResultDto<PagingApiScopeListOutput>> GetListAsync(PagingApiScopeListInput input);

        Task CreateAsync(CreateApiScopeInput input);

        Task UpdateAsync(UpdateCreateApiScopeInput input);
        
        Task DeleteAsync(IdInput input);

        Task<List<FromSelector<string, string>>> FindAllAsync();
    }
}