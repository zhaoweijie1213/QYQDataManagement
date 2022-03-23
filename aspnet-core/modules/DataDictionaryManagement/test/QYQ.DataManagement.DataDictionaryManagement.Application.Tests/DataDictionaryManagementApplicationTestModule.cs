using Volo.Abp.Modularity;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementApplicationModule),
        typeof(DataDictionaryManagementDomainTestModule)
        )]
    public class DataDictionaryManagementApplicationTestModule : AbpModule
    {

    }
}
