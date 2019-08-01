using Brunel_Sailing_Web.Data;
using Brunel_Sailing_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(ApplicationContext context) :base(context)
        {

        }

        public Task CreateEventAsync(Event cEvent)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEventAsync(Event dEvent)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetEventByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEventAsync(Event uEvent)
        {
            throw new NotImplementedException();
        }
    }
}
