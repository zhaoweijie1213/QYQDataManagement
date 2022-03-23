using AutoMapper;
using QYQ.DataManagement.NotificationManagement.Notifications;
using QYQ.DataManagement.NotificationManagement.Notifications.Aggregates;
using QYQ.DataManagement.NotificationManagement.Notifications.Etos;

namespace QYQ.DataManagement.NotificationManagement
{
    public class NotificationDomainAutoMapperProfile:Profile
    {
        public NotificationDomainAutoMapperProfile()
        {
            CreateMap<Notification, NotificationEto>();
            CreateMap<NotificationSubscription, NotificationSubscriptionEto>();
        }
    }
}