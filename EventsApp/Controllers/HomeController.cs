﻿using EventsApp.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventsApp.ViewModels;
using Microsoft.AspNet.Identity;

namespace EventsApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string search = null)
        {
            var upcomingGigs = _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .Where(g => g.DateTime > DateTime.Now && !g.IsCanceled);

            if (!string.IsNullOrWhiteSpace(search))
            {
                upcomingGigs = upcomingGigs
                    .Where(g => g.Artist.Name.Contains(search) ||
                                g.Genre.Name.Contains(search) ||
                                g.Venue.Contains(search));
            }

            var userId = User.Identity.GetUserId();
            var attendances = _context.Attendances
                .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                .ToList()
                .ToLookup(a => a.GigId);

            var viewModel = new GigsViewModel
            {
                UpcomingGigs = upcomingGigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Upcoming Gigs",
                SearchTerm = search,
                Attendances = attendances
            };

            return View("Gigs", viewModel);
        }

    }
}