using QYQ.DataManagement.AuditLogs;
using QYQ.DataManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace QYQ.DataManagement.Controllers.Systems
{
    [Route("AuditLogs")]
    public class AuditLogController : DataManagementController,IAuditLogAppService
    {
        private readonly IAuditLogAppService _auditLogAppService;

        public AuditLogController(IAuditLogAppService auditLogAppService)
        {
            _auditLogAppService = auditLogAppService;
        }

        [HttpPost("page")]
        [SwaggerOperation(summary: "分页获取审计日志信息", Tags = new[] {"AuditLogs"})]
        public Task<PagedResultDto<GetAuditLogPageListOutput>> GetListAsync(PagingAuditLogListInput input)
        {
            return _auditLogAppService.GetListAsync(input);
        }
    }
}