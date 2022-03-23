using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.FileManagement.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}