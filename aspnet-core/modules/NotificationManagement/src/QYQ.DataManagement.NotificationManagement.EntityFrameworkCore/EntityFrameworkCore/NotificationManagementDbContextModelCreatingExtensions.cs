using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using QYQ.DataManagement.NotificationManagement.Notifications;
using QYQ.DataManagement.NotificationManagement.Notifications.Aggregates;

namespace QYQ.DataManagement.NotificationManagement.EntityFrameworkCore
{
    public static class NotificationManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureNotificationManagement(
            this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Notification>(b =>
            {
                b.ToTable(NotificationManagementDbProperties.DbTablePrefix + nameof(Notification),
                    NotificationManagementDbProperties.DbSchema);
                b.ConfigureByConvention();
            });
            
            builder.Entity<NotificationSubscription>(b =>
            {
                b.ToTable(NotificationManagementDbProperties.DbTablePrefix + nameof(NotificationSubscription),
                    NotificationManagementDbProperties.DbSchema);
                b.ConfigureByConvention();
            });
        }
    }
}