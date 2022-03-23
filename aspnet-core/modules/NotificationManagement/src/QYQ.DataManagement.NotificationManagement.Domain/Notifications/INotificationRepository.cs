using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using QYQ.DataManagement.NotificationManagement.Notifications.Aggregates;
using Volo.Abp.Domain.Repositories;

namespace QYQ.DataManagement.NotificationManagement.Notifications
{
    /// <summary>
    /// 消息通知 仓储接口
    /// </summary>
    public partial interface INotificationRepository : IBasicRepository<Notification, Guid>
    {
        /// <summary>
        /// 查找用户消息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Notification> FindByIdAsync(Guid id);
        
    }
}