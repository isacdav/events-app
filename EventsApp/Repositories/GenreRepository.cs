﻿using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Repositories
{
    public class GenreRepository
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