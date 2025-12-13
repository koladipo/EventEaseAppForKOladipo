using System.Collections.Generic;
using System.Linq;

namespace EventApp.Data
{
    public class EventService
    {
        private readonly List<EventModel> events = new()
        {
            new EventModel { Id = 1, Name = "Tech Conference", Date = DateTime.Now.AddDays(10), Location = "London", Description = "A conference about tech.", ImageUrl="https://thumbs.dreamstime.com/b/house-tree-logo-105126143.jpg" },
            new EventModel { Id = 2, Name = "Music Festival", Date = DateTime.Now.AddDays(20), Location = "Manchester", Description = "A festival of music.", ImageUrl="https://thumbs.dreamstime.com/b/house-tree-logo-105126143.jpg" },
            new EventModel { Id = 3, Name = "Art Expo", Date = DateTime.Now.AddDays(30), Location = "Liverpool", Description = "An exhibition of art.", ImageUrl="https://thumbs.dreamstime.com/b/house-tree-logo-105126143.jpg" }
        };

        public List<EventModel> GetEvents() => events;

        public EventModel? GetEventById(int id) => events.FirstOrDefault(e => e.Id == id);
    }
}
