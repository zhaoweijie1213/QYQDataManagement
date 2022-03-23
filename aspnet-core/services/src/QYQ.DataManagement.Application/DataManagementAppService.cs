using System;
using System.Collections.Generic;
using System.Text;
using QYQ.DataManagement.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Localization;

namespace QYQ.DataManagement
{
    /* Inherit your application services from this class.
     */
    public abstract class DataManagementAppService : ApplicationService
    {
        protected DataManagementAppService()
        {
            LocalizationResource = typeof(DataManagementResource);
        }
    }
}
