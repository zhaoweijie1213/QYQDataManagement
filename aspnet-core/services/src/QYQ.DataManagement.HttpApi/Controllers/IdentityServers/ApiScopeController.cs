using System.Collections.Generic;
using System.Threading.Tasks;
using QYQ.DataManagement.Extension.Customs.Dtos;
using QYQ.DataManagement.IdentityServers.ApiScopes;
using QYQ.DataManagement.IdentityServers.ApiScopes.Dtos;
using QYQ.DataManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Volo.Abp.Application.Dtos;

namespace QYQ.DataManagement.Controllers.IdentityServers
{
    [Route("IdentityServer/ApiScope")]
    public class ApiScopeController : DataManagementController, IApiScopeAppService
    {
        private readonly IApiScopeAppService _apiScopeAppService;

        public ApiScopeController(IApiScopeAppService apiScopeAppService)
        {
            _apiScopeAppService = apiScopeAppService;
        }

        [HttpPost("page")]
        [SwaggerOperation(summary: "分页获取ApiScope信息", Tags = new[] { "ApiScope" })]
        public Task<PagedResultDto<PagingApiScopeListOutput>> GetListAsync(
            PagingApiScopeListInput input)
        {
            return _apiScopeAppService.GetListAsync(input);
        }

        [HttpPost("create")]
        [SwaggerOperation(summary: "创建ApiScope", Tags = new[] { "ApiScope" })]
        public Task CreateAsync(CreateApiScopeInput input)
        {
            return _apiScopeAppService.CreateAsync(input);
        }

        [HttpPost("update")]
        [SwaggerOperation(summary: "更新ApiScope", Tags = new[] { "ApiScope" })]
        public Task UpdateAsync(UpdateCreateApiScopeInput input)
        {
            return _apiScopeAppService.UpdateAsync(input);
        }

        [HttpPost("delete")]
        [SwaggerOperation(summary: "删除ApiScope", Tags = new[] { "ApiScope" })]
        public Task DeleteAsync(IdInput input)
        {
            return _apiScopeAppService.DeleteAsync(input);
        }

        [HttpPost("all")]
        [SwaggerOperation(summary: "获取所有ApiScope", Tags = new[] { "ApiScope" })]
        public Task<List<FromSelector<string, string>>> FindAllAsync()
        {
            return _apiScopeAppService.FindAllAsync();
        }
    }
}