using QYQ.DataManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement
{
    [DependsOn(
        typeof(DataManagementEntityFrameworkCoreTestModule)
        )]
    public class DataManagementDomainTestModule : AbpModule
    {

    }
}