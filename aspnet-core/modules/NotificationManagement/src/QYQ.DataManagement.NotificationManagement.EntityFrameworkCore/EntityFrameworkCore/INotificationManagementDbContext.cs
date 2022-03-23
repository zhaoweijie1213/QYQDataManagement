using QYQ.DataManagement.NotificationManagement.Notifications;
using QYQ.DataManagement.NotificationManagement.Notifications.Aggregates;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QYQ.DataManagement.NotificationManagement.EntityFrameworkCore
{
    [ConnectionStringName(NotificationManagementDbProperties.ConnectionStringName)]
    public interface INotificationManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        
        DbSet<Notification> Notifications { get; set; }
    }
}