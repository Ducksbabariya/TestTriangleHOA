using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTriangle.HOA.API.Command.Generic;
using TestTriangle.HOA.API.Command.Handler;
using TestTriangle.HOA.API.Query;
using TestTriangle.HOA.API.Query.Generic;
using TestTriangle.HOA.API.Query.Handler;
using TestTriangle.HOA.Data.Models;

namespace TestTriangle.HOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class TicketController : ControllerBase
    {
        private readonly TicketCommandHandler _ticketCommandHandler;
        private readonly TicketQueryHandler _ticketQueryHandler;

        public TicketController(TicketCommandHandler ticketCommandHandler,
                                TicketQueryHandler ticketQueryHandler)
        {
            _ticketCommandHandler = ticketCommandHandler;
            _ticketQueryHandler = ticketQueryHandler;
        }

        // GET: api/Ticket/1
        [HttpGet("GetCustomerTickets/{customerId}")]
        public async Task<ActionResult<BaseResponse<Ticket>>> GetTicketsByCustomer(int customerId, int page, int pageSize)
        {
            var query = new GetCustomerTicketsQuery(customerId, page, pageSize)
            {
                CustomerId = customerId
            };
            var tickets =  _ticketQueryHandler.HandleAsync(query);
            if (tickets.Data.Count() <= 0)
            {
                return NoContent();
            }
            return tickets;
        }

        // GET: api/Ticket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(int id)
        {
            var query = new FindQuery<Ticket>()
            {
                Id = id
            };
            var ticket = await _ticketQueryHandler.HandleAsync(query);

            if (ticket == null)
            {
                return NotFound(new { message = "Ticket not found" });
            }

            return ticket;
        }

        // PUT: api/Ticket/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Ticket ticket)
        {
            if (id != ticket.TicketId)
            {
                return BadRequest();
            }

            try
            {
                var command = new UpdateCommand<Ticket>()
                {
                    Id = id,
                    Data = ticket
                };
                bool result = await _ticketCommandHandler.HandleAsync(command);

                if (!result)
                {
                    return NotFound(new { message = "Ticket not found" });
                }
                return Ok();
            }
            catch (Exception ex)
            {
                // log ex as exception
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST: api/Ticket
        [HttpPost]
        public async Task<ActionResult<Ticket>> PostTicket(Ticket ticket)
        {
            var command = new InsertCommand<Ticket>()
            {
                Data = ticket
            };
            int ticketId = await _ticketCommandHandler.HandleAsync(command);

            return CreatedAtAction("GetTicket", new { id = ticketId }, ticket);
        }

        // DELETE: api/Ticket/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteTicket(int id)
        {
            var command = new DeleteCommand()
            {
                Id = id
            };
            return await _ticketCommandHandler.HandleAsync(command);
        }
        
    }
}
