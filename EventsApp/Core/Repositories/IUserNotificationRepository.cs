using EventsApp.Core.Models;
using System.Collections.Generic;

namespace EventsApp.Core.Repositories
{
    public interface IUserNotificationRepository
    {
        IEnumerable<UserNotification> GetUserNotificationsFor(string userId);
    }
}
