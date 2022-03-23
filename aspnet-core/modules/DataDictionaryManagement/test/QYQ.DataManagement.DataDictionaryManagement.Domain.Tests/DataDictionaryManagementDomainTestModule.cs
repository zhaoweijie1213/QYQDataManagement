using QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(DataDictionaryManagementEntityFrameworkCoreTestModule)
        )]
    public class DataDictionaryManagementDomainTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DataDictionaryManagementDomainModule>(validate: true);
            });
        }
    }
}
