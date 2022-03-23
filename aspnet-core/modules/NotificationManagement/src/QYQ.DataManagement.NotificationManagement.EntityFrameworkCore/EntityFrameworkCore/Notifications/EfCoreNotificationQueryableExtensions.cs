using System.Linq;
using Microsoft.EntityFrameworkCore;
using QYQ.DataManagement.NotificationManagement.Notifications;
using QYQ.DataManagement.NotificationManagement.Notifications.Aggregates;

namespace QYQ.DataManagement.NotificationManagement.EntityFrameworkCore.Notifications
{
    public static class EfCoreNotificationQueryableExtensions
    {
        public static IQueryable<Notification> IncludeDetails(this IQueryable<Notification> queryable, bool include = true)
        {
            return !include ? queryable : queryable.Include(e => e.NotificationSubscriptions);
        }
    }
}