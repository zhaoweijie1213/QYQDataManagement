using QYQ.DataManagement.NotificationManagement.Notifications.Etos;

namespace QYQ.DataManagement.NotificationManagement.Notifications.DistributedEvents
{
    public class CreatedNotificationDistributedEvent
    {
        public NotificationEto NotificationEto { get;  set; }

        private CreatedNotificationDistributedEvent()
        {
            
        }

        public CreatedNotificationDistributedEvent(NotificationEto notificationEto)
        {
            NotificationEto = notificationEto;
        }
    }
}