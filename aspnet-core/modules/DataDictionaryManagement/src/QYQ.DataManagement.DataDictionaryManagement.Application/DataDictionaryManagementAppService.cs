using QYQ.DataManagement.DataDictionaryManagement.Localization;
using Volo.Abp.Application.Services;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    public abstract class DataDictionaryManagementAppService : ApplicationService
    {
        protected DataDictionaryManagementAppService()
        {
            LocalizationResource = typeof(DataDictionaryManagementResource);
            ObjectMapperContext = typeof(DataDictionaryManagementApplicationModule);
        }
    }
}
