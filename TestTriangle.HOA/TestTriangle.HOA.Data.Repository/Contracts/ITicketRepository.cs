using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTriangle.HOA.Data.Models;

namespace TestTriangle.HOA.Data.Repository.Contracts
{
    public interface ITicketRepository
    {
        BaseResponse<Ticket> GetTicketsAsync(int customerId, int page = 1, int pageSize = 50);
        Task<Ticket> FindTicketAsync(int id);
        Task<int> InsertTicketAsync(Ticket ticket);
        Task<bool> UpdatTicketAsync(int id, Ticket ticket);
        Task<bool> DeleteTicketAsync(int id);

    }
}
