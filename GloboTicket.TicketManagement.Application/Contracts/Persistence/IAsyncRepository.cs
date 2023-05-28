using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> AddAsync(T entity);

        Task<IReadOnlyList<T>> UpdateAsync(T entity);

        Task<IReadOnlyList<T>> DeleteAsync(T entity);


    }
}
