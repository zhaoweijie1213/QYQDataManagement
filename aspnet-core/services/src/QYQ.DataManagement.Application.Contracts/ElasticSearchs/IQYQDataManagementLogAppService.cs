using System.Threading.Tasks;
using QYQ.DataManagement.ElasticSearchs.Dto;
using QYQ.DataManagement.Extension.Customs.Dtos;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.ElasticSearchs
{
    public interface IQYQDataManagementLogAppService : IApplicationService
    {
        /// <summary>
        /// 分页查询es日志
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<CustomePagedResultDto<PagingElasticSearchLogOutput>> PaingAsync(PagingElasticSearchLogInput input);
    }
}