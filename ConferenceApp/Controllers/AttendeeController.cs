using ConferenceApp.Data;
using ConferenceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttendeeController : ControllerBase
    {
        [HttpGet(Name = "GetAttendees")]
        public IEnumerable<Attendee> Get()
        {

            return InMemoryCollection.Attendees;
        }

        [HttpPost(Name = "AddAttendee")]
        public IActionResult Post(Attendee attendee)
        {

            InMemoryCollection.Attendees.Add(attendee);
            return NoContent();
        }
    }
}
