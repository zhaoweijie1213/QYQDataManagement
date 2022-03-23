using QYQ.DataManagement.NotificationManagement.Localization;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.NotificationManagement
{
    public abstract class NotificationManagementAppService : ApplicationService
    {
        protected NotificationManagementAppService()
        {
            LocalizationResource = typeof(NotificationManagementResource);
            ObjectMapperContext = typeof(NotificationManagementApplicationModule);
        }
    }
}
