using EventsApp.Core.Models;
using System.Collections.Generic;

namespace EventsApp.Core.Repositories
{
    public interface IAttendanceRepository
    {
        void Add(Attendance attendance);
        void Remove(Attendance attendance);
        Attendance GetAttendance(int id, string userId);
        IEnumerable<Attendance> GetFutureAttendances(string userId);
    }
}