using EventsApp.Core.Repositories;

namespace EventsApp.Core
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository ApplicationUser { get; }
        IAttendanceRepository Attendances { get; }
        IFollowingRepository Followings { get; }
        IGenreRepository Genres { get; }
        IGigRepository Gigs { get; }
        INotificationRepository Notification { get; }
        IUserNotificationRepository UserNotification { get; }

        void Complete();
    }
}