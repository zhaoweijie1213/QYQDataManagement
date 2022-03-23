using QYQ.DataManagement.DataDictionaryManagement;
using QYQ.DataManagement.FileManagement;
using QYQ.DataManagement.NotificationManagement;
using Volo.Abp.Account;
using Volo.Abp.AuditLogging;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace QYQ.DataManagement
{
    [DependsOn(
        typeof(DataManagementDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(DataManagementApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpSettingManagementApplicationModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(DataDictionaryManagementApplicationModule),
        typeof(NotificationManagementApplicationModule),
        typeof(FileManagementApplicationModule)
        )]
    public class DataManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DataManagementApplicationModule>();
            });
            
          
        }
    }
}
