using QYQ.DataManagement.DataDictionaryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    public abstract class DataDictionaryManagementController : AbpController
    {
        protected DataDictionaryManagementController()
        {
            LocalizationResource = typeof(DataDictionaryManagementResource);
        }
    }
}
