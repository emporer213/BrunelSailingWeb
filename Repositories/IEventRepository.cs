using Brunel_Sailing_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Repositories
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task CreateEventAsync(Event cEvent);
        Task UpdateEventAsync(Event uEvent);
        Task DeleteEventAsync(Event dEvent);
    }
}
