namespace EventEase.Models;

public class Attendance
{
    public int EventId { get; set; }
    public string UserEmail { get; set; } = "";
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
