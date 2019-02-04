using EventsApp.Core;
using EventsApp.Persistence;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class FolloweesController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public FolloweesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artists = _unitOfWork.ApplicationUser.GetArtistsFollowedBy(userId);

            return View(artists);
        }
    }
}