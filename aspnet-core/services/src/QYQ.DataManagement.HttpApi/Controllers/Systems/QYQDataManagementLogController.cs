using System.Threading.Tasks;
using QYQ.DataManagement.ElasticSearchs;
using QYQ.DataManagement.ElasticSearchs.Dto;
using QYQ.DataManagement.Permissions;
using QYQ.DataManagement.Extension.Customs.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace QYQ.DataManagement.Controllers.Systems
{
    [Route("EsLog")]
    public class QYQDataManagementLogController: DataManagementController,IQYQDataManagementLogAppService
    {
        private readonly IQYQDataManagementLogAppService _companyNameDataManagementLogAppService;

        public QYQDataManagementLogController(IQYQDataManagementLogAppService companyNameDataManagementLogAppService)
        {
            _companyNameDataManagementLogAppService = companyNameDataManagementLogAppService;
        }
        
        [HttpPost("page")]
        [SwaggerOperation(summary: "分页获取Es日志", Tags = new[] { "EsLog" })]
        public Task<CustomePagedResultDto<PagingElasticSearchLogOutput>> PaingAsync(PagingElasticSearchLogInput input)
        {
            return _companyNameDataManagementLogAppService.PaingAsync(input);
        }
    }
}