using Volo.Abp.EventBus;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.CAP
{
    [DependsOn(typeof(AbpEventBusModule))]
    public class DataManagementAbpCapModule : AbpModule
    {
    }
}