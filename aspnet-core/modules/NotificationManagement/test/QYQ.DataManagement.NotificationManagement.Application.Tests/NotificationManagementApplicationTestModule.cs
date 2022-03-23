using Volo.Abp.Modularity;

namespace QYQ.DataManagement.NotificationManagement
{
    [DependsOn(
        typeof(NotificationManagementApplicationModule),
        typeof(NotificationManagementDomainTestModule)
        )]
    public class NotificationManagementApplicationTestModule : AbpModule
    {

    }
}
