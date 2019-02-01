using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Repositories
{
    public class AttendanceRepository
    {
        private ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                           .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                           .ToList();
        }

        public Attendance GetAttendance(int id, string userId)
        {
            return _context.Attendances
                    .SingleOrDefault(a => a.GigId == id && a.AttendeeId == userId);
        }
    }
}