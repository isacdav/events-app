using EventsApp.Core.Models;
using EventsApp.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventsApp.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}