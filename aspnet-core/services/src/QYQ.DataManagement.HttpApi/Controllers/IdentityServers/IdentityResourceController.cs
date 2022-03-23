using System.Collections.Generic;
using System.Threading.Tasks;
using QYQ.DataManagement.IdentityServers.IdentityResources;
using QYQ.DataManagement.IdentityServers.IdentityResources.Dtos;
using QYQ.DataManagement.Permissions;
using QYQ.DataManagement.Extension.Customs.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Volo.Abp.Application.Dtos;

namespace QYQ.DataManagement.Controllers.IdentityServers
{
    [Route("IdentityServer/IdentityResource")]
    public class IdentityResourceController : DataManagementController, IIdentityResourceAppService
    {
        private readonly IIdentityResourceAppService _identityResourceAppService;

        public IdentityResourceController(IIdentityResourceAppService identityResourceAppService)
        {
            _identityResourceAppService = identityResourceAppService;
        }

        [HttpPost("page")]
        [SwaggerOperation(summary: "分页获取IdentityResource信息", Tags = new[] { "IdentityResource" })]
        public Task<PagedResultDto<PagingIdentityResourceListOutput>> GetListAsync(
            PagingIdentityResourceListInput input)
        {
            return _identityResourceAppService.GetListAsync(input);
        }

        [HttpPost("all")]
        [SwaggerOperation(summary: "获取所有IdentityResource信息", Tags = new[] { "IdentityResource" })]
        public Task<List<PagingIdentityResourceListOutput>> GetAllAsync()
        {
            return _identityResourceAppService.GetAllAsync();
        }

        [HttpPost("create")]
        [SwaggerOperation(summary: "创建IdentityResource", Tags = new[] { "IdentityResource" })]
        public Task CreateAsync(CreateIdentityResourceInput input)
        {
            return _identityResourceAppService.CreateAsync(input);
        }

        [HttpPost("update")]
        [SwaggerOperation(summary: "更新IdentityResource", Tags = new[] { "IdentityResource" })]
        public Task UpdateAsync(UpdateIdentityResourceInput input)
        {
            return _identityResourceAppService.UpdateAsync(input);
        }

        [HttpPost("delete")]
        [SwaggerOperation(summary: "删除IdentityResource", Tags = new[] { "IdentityResource" })]
        public Task DeleteAsync(IdInput input)
        {
            return _identityResourceAppService.DeleteAsync(input);
        }
    }
}