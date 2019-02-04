using EventsApp.Core;
using EventsApp.Core.ViewModels;
using EventsApp.Persistence;
using EventsApp.Persistence.Repositories;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index(string search = null)
        {
            var upcomingGigs = _unitOfWork.Gigs.GetUpcomingGigs(search);

            var userId = User.Identity.GetUserId();
            var attendances = _unitOfWork.Attendances.GetFutureAttendances(userId)
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