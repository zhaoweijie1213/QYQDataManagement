using AutoMapper;
using QYQ.DataManagement.NotificationManagement.Notifications.Aggregates;
using QYQ.DataManagement.NotificationManagement.Notifications.Etos;

namespace QYQ.DataManagement.NotificationManagement.Notifications
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