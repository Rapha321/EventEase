using EventEase.Models;

namespace EventEase.Services;

public class RegistrationService
{
    private readonly List<Registration> _registrations = new();
    public string? LastRegisteredEmail { get; set; }


    public void Register(Registration registration)
    {
        _registrations.Add(registration);
        LastRegisteredEmail = registration.Email;
    }


    public IEnumerable<Registration> GetRegistrationsForEvent(int eventId)
    {
        return _registrations.Where(r => r.EventId == eventId);
    }

    public IEnumerable<Registration> GetAllRegistrations()
    {
        return _registrations;
    }

    public void Unregister(int eventId, string email)
    {
        var registration = _registrations
            .FirstOrDefault(r => r.EventId == eventId && r.Email == email);

        if (registration is not null)
            _registrations.Remove(registration);
    }

    public bool IsRegistered(int eventId, string email)
    {
        return _registrations.Any(r => r.EventId == eventId && r.Email == email);
    }

}
