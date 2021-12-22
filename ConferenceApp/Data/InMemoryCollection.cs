using ConferenceApp.Models;

namespace ConferenceApp.Data
{
    public static class InMemoryCollection
    {
        public static List<Attendee> Attendees { get; set; } = new List<Attendee>();
    }
}

