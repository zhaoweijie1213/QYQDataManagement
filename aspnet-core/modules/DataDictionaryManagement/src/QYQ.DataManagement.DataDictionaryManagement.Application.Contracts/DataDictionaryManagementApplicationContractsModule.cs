using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class DataDictionaryManagementApplicationContractsModule : AbpModule
    {

    }
}
