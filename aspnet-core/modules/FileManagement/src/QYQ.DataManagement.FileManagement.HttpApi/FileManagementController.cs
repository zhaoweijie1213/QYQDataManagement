using QYQ.DataManagement.FileManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QYQ.DataManagement.FileManagement;

public abstract class FileManagementController : AbpControllerBase
{
    protected FileManagementController()
    {
        LocalizationResource = typeof(FileManagementResource);
    }
}