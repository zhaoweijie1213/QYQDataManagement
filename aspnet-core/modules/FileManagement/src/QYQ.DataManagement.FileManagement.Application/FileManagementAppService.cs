using QYQ.DataManagement.FileManagement.Localization;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.FileManagement;

public abstract class FileManagementAppService : ApplicationService
{
    protected FileManagementAppService()
    {
        LocalizationResource = typeof(FileManagementResource);
        ObjectMapperContext = typeof(FileManagementApplicationModule);
    }
}