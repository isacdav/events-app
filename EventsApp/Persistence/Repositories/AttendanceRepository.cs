using EventsApp.Core.Models;
using EventsApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsApp.Persistence.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
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

        public void Add(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
        }

        public void Remove(Attendance attendance)
        {
            _context.Attendances.Remove(attendance);
        }

    }
}