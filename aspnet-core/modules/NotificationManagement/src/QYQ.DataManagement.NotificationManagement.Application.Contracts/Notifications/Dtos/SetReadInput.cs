using System;

namespace QYQ.DataManagement.NotificationManagement.Notifications.Dtos
{
    public class SetReadInput
    {
        public Guid Id { get; set; }
        
        public Guid ReceiveId { get; set; }
    }
}