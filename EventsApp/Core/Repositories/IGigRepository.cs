using EventsApp.Core.Models;
using System.Collections.Generic;

namespace EventsApp.Core.Repositories
{
    public interface IGigRepository
    {
        void Add(Gig gig);
        Gig GetGig(int id);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int id);
        List<Gig> GetUserGigs(string userId);
        IEnumerable<Gig> GetUpcomingGigs(string searchTerm = null);
    }
}