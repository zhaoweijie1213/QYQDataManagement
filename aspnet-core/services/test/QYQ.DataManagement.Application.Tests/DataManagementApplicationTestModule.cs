using Volo.Abp.Modularity;

namespace QYQ.DataManagement
{
    [DependsOn(
        typeof(DataManagementApplicationModule),
        typeof(DataManagementDomainTestModule)
        )]
    public class DataManagementApplicationTestModule : AbpModule
    {

    }
}