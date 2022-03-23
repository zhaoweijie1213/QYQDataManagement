using QYQ.DataManagement.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace QYQ.DataManagement.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DataManagementController : AbpController
    {
        protected DataManagementController()
        {
            LocalizationResource = typeof(DataManagementResource);
        }
    }
}