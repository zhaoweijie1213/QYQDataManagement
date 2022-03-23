using QYQ.DataManagement.DataDictionaryManagement;
using QYQ.DataManagement.FileManagement;
using QYQ.DataManagement.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Data;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Localization;
using Volo.Abp.IdentityServer;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Localization.Resources.AbpLocalization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Localization;
using Volo.Abp.TenantManagement;
using Volo.Abp.Threading;
using Volo.Abp.Timing.Localization.Resources.AbpTiming;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace QYQ.DataManagement
{
    [DependsOn(
        typeof(AbpAuditLoggingDomainSharedModule),
        typeof(AbpBackgroundJobsDomainSharedModule),
        typeof(AbpFeatureManagementDomainSharedModule),
        typeof(AbpIdentityDomainSharedModule),
        typeof(AbpIdentityServerDomainSharedModule),
        typeof(AbpPermissionManagementDomainSharedModule),
        typeof(AbpSettingManagementDomainSharedModule),
        typeof(AbpTenantManagementDomainSharedModule),
        typeof(DataDictionaryManagementDomainSharedModule),
        typeof(FileManagementDomainSharedModule)
    )]
    public class DataManagementDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            DataManagementGlobalFeatureConfigurator.Configure();
            DataManagementModuleExtensionConfigurator.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<DataManagementDomainSharedModule>("QYQ.DataManagement");
            });
          
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<DataManagementResource>("zh-Hans")
                    .AddVirtualJson("/Localization/DataManagement")
                    .AddBaseTypes(typeof(IdentityResource))
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddBaseTypes(typeof(AbpLocalizationResource))
                    .AddBaseTypes(typeof(AbpTimingResource))
                    .AddBaseTypes(typeof(AbpSettingManagementResource));

                options.DefaultResourceType = typeof(DataManagementResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("DataManagement", typeof(DataManagementResource));
            });
        }

       
    }
}