using EventsApp.Core;
using EventsApp.Core.Repositories;
using EventsApp.Persistence.Repositories;

namespace EventsApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGigRepository Gigs { get; private set; }
        public IAttendanceRepository Attendances { get; private set; }
        public IFollowingRepository Followings { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public INotificationRepository Notification { get; private set; }
        public IUserNotificationRepository UserNotification { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(_context);
            Attendances = new AttendanceRepository(_context);
            Followings = new FollowingRepository(_context);
            Genres = new GenreRepository(_context);
            Notification = new NotificationRepository(_context);
            UserNotification = new UserNotificationRepository(_context);
            ApplicationUser = new ApplicationUserRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
        
    }
}