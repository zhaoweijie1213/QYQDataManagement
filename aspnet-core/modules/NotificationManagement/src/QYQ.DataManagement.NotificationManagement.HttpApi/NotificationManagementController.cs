using QYQ.DataManagement.NotificationManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QYQ.DataManagement.NotificationManagement
{
    public abstract class NotificationManagementController : AbpController
    {
        protected NotificationManagementController()
        {
            LocalizationResource = typeof(NotificationManagementResource);
        }
    }
}
