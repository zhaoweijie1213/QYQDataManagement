using Microsoft.AspNetCore.Authorization;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Auditing;

namespace QYQ.DataManagement.NotificationManagement.Hubs
{
    [HubRoute("SignalR/Notification")]
    [Authorize]
    [DisableAuditing]
    public class NotificationHub : AbpHub<INotificationHub>
    {
        
    }
}