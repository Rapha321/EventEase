using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<Event> _events = new()
    {
        new Event { Id = 1, Name = "Tech Summit 2025", Date = new DateTime(2025, 5, 12), Location = "Montreal", Description = "A summit for tech leaders." }, 
        new Event { Id = 2, Name = "Corporate Gala", Date = new DateTime(2025, 6, 20), Location = "Toronto", Description = "Annual corporate celebration." }, 
        new Event { Id = 3, Name = "Startup Expo", Date = new DateTime(2025, 7, 5), Location = "Vancouver", Description = "Showcase of new startups." }, 
        new Event { Id = 4, Name = "AI & Robotics Conference", Date = new DateTime(2025, 8, 14), Location = "Ottawa", Description = "Exploring the future of automation and AI." }, 
        new Event { Id = 5, Name = "Green Energy Forum", Date = new DateTime(2025, 9, 3), Location = "Calgary", Description = "Discussions on renewable energy innovations." }, 
        new Event { Id = 6, Name = "Healthcare Leadership Summit", Date = new DateTime(2025, 10, 11), Location = "Edmonton", Description = "Leadership strategies in modern healthcare." }, 
        new Event { Id = 7, Name = "Digital Marketing Bootcamp", Date = new DateTime(2025, 11, 2), Location = "Halifax", Description = "Hands-on digital marketing training." }, 
        new Event { Id = 8, Name = "Winter Tech Expo", Date = new DateTime(2025, 12, 15), Location = "Winnipeg", Description = "End-of-year technology showcase." }, 
        new Event { Id = 9, Name = "Blockchain World Summit", Date = new DateTime(2026, 1, 20), Location = "Toronto", Description = "The latest in blockchain and Web3." }, 
        new Event { Id = 10, Name = "Women in Leadership Conference", Date = new DateTime(2026, 2, 8), Location = "Montreal", Description = "Empowering women in business and tech." }, 
        new Event { Id = 11, Name = "Cybersecurity Essentials Workshop", Date = new DateTime(2026, 3, 12), Location = "Vancouver", Description = "Protecting digital assets in a modern world." }, 
        new Event { Id = 12, Name = "Real Estate Investment Expo", Date = new DateTime(2026, 4, 5), Location = "Calgary", Description = "Strategies for real estate investors." }, 
        new Event { Id = 13, Name = "Food & Culture Festival", Date = new DateTime(2026, 5, 18), Location = "Quebec City", Description = "Celebrating global cuisine and culture." }, 
        new Event { Id = 14, Name = "Music & Arts Fair", Date = new DateTime(2026, 6, 22), Location = "Toronto", Description = "Live performances and art exhibitions." }, 
        new Event { Id = 15, Name = "Outdoor Adventure Expo", Date = new DateTime(2026, 7, 10), Location = "Banff", Description = "Gear, workshops, and outdoor experiences." }
    };

    public List<Event> GetEvents() => _events;

    public Event? GetEventById(int id) =>
        _events.FirstOrDefault(e => e.Id == id);
}
