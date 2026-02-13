using EventEase.Models;

namespace EventEase.Services;

public class AttendanceService
{
    private readonly List<Attendance> _attendance = new();

    public void MarkAttendance(int eventId, string userEmail)
    {
        // Prevent duplicates
        if (!_attendance.Any(a => a.EventId == eventId && a.UserEmail == userEmail))
        {
            _attendance.Add(new Attendance
            {
                EventId = eventId,
                UserEmail = userEmail,
                Timestamp = DateTime.Now
            });
        }
    }

    public List<Attendance> GetAttendanceForUser(string email)
    {
        return _attendance.Where(a => a.UserEmail == email).ToList();
    }

    public int GetAttendanceCount(int eventId)
    {
        return _attendance.Count(a => a.EventId == eventId);
    }
}
