using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTriangle.HOA.API.Command.Generic;
using TestTriangle.HOA.API.Command.Handler;
using TestTriangle.HOA.API.Query.Generic;
using TestTriangle.HOA.API.Query.Handler;
using TestTriangle.HOA.Data.Models;

namespace TestTriangle.HOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerCommandHandler _customerCommandHandler;
        private readonly CustomerQueryHandler _customerQueryHandler;

        public CustomerController(CustomerCommandHandler customerCommandHandler,
                                  CustomerQueryHandler customerQueryHandler)
        {
            _customerCommandHandler = customerCommandHandler;
            _customerQueryHandler = customerQueryHandler;

        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<BaseResponse<Customer>>> GetCustomers(int page, int pageSize)
        {
            var query = new GetAllQuery<Customer>(page, pageSize);
            var customers = _customerQueryHandler.HandleAsync(query);
            //if (await customers.Data.Count() <= 0)
            //{
            //    return NotFound();
            //}
            return customers;
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var query = new FindQuery<Customer>() { Id = id };
            var customer = await _customerQueryHandler.HandleAsync(query);

            if (customer == null)
            {
                return NotFound(new { message = "Customer not found" });
            }

            return customer;
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            try
            {
                var command = new UpdateCommand<Customer>()
                {
                    Id = id,
                    Data = customer
                };

                bool result = await _customerCommandHandler.HandleAsync(command);

                if (!result)
                {
                    return NotFound(new { message = "Customer not found" });
                }
                return Ok();
            }
            catch (Exception ex)
            {
                // log ex as exception
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST: api/Customer
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            var command = new InsertCommand<Customer>()
            {
                Data = customer
            };
            int customerId = await _customerCommandHandler.HandleAsync(command);

            return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteCustomer(int id)
        {
            var command = new DeleteCommand() { Id = id };
            return await _customerCommandHandler.HandleAsync(command);
        }
    }
}
