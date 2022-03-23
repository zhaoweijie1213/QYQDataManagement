using QYQ.DataManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DataManagementEntityFrameworkCoreModule),
        typeof(DataManagementApplicationContractsModule)
        )]
    public class DataManagementDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
