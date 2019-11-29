using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTriangle.HOA.Data.Models;
using TestTriangle.HOA.Data.Repository.Contracts;

namespace TestTriangle.HOA.Data.Repository.Implementation
{
    public class TicketRepository : ITicketRepository
    {
        TestTriangleHOAContext _context;

        public TicketRepository(TestTriangleHOAContext context)
        {
            _context = context;
        }

        public TicketRepository()
        {
            _context = new TestTriangleHOAContext();
        }

        public async Task<IList<Ticket>> GetTicketsAsync(int customerId) => 
            await _context.Ticket.Where(t => t.CustomerId == customerId).ToListAsync();

        public BaseResponse<Ticket> GetTicketsAsync(int customerId, int page = 1, int pageSize = 50)
        {
            var data =
            _context.Ticket.AsQueryable()
            .Where(t => t.CustomerId == customerId)
            .OrderByDescending(o => o.CreatedBy)
            .Skip(page > 1 ? (page - 1) * pageSize : 0)
            .Take(pageSize);

            var count = _context.Ticket.Where(t => t.CustomerId == customerId).Count();

            return new BaseResponse<Ticket>()
            {
                Data = data,
                TotalCount = count
            };
        }

        public async Task<Ticket> FindTicketAsync(int id)
        {
            return await _context.Ticket.FindAsync(id);
        }

        public async Task<int> InsertTicketAsync(Ticket ticket)
        {
            _context.Ticket.Add(ticket);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatTicketAsync(int id, Ticket ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await TicketExistsAsync(id))
                {
                    return false;
                }
                else
                {
                    throw ex;
                }
            }
        }

        public async Task<bool> DeleteTicketAsync(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return false;
            }

            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();

            return true;
        }


        private async Task<bool> TicketExistsAsync(int id)
        {
            return await _context.Ticket.AnyAsync(e => e.TicketId == id);
        }

    }
}
