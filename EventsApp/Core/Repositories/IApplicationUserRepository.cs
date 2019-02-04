using EventsApp.Core.Models;
using System.Collections.Generic;

namespace EventsApp.Core.Repositories
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetArtistsFollowedBy(string userId);
    }
}
