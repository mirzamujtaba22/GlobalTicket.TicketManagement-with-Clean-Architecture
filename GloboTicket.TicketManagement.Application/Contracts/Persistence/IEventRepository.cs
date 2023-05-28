using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    internal class IEventRepository : IAsyncRepository<Event>
    {
        public Task<IReadOnlyList<Event>> AddAsync(Event entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Event>> DeleteAsync(Event entity)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Event>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Event>> UpdateAsync(Event entity)
        {
            throw new NotImplementedException();
        }
    }
}
