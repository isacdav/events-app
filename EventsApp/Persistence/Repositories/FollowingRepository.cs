using EventsApp.Core.Models;
using EventsApp.Core.Repositories;
using System.Linq;

namespace EventsApp.Persistence.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Following following)
        {
            _context.Followings.Add(following);
        }

        public Following GetFollowing(string userId, string artistId)
        {
            return _context.Followings.SingleOrDefault(f => f.FolloweeId == artistId && f.FollowerId == userId);
        }

        public void Remove(Following following)
        {
            _context.Followings.Remove(following);
        }
    }
}