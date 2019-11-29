using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestTriangleHOA.Web.Models;
using TestTriangleHOA.Web.Service;

namespace TestTriangleHOA.Web.Controllers
{
    public class TicketController : Controller
    {
        private RestService _restService;

        public TicketController(RestService restService)
        {
            _restService = restService;
        }

        // GET: /<controller>/
        public IActionResult Index([FromQuery]int customerId, [FromQuery]int page = 1, [FromQuery]int pageSize = 50)
        {
            var result = _restService.SendAsync<BaseResponse<Ticket>>($"api/Ticket/GetCustomerTickets/{customerId}?page={page}&pageSize={pageSize}", HttpMethod.Get);
            //ViewBag.Customers = customers.Select(s => new SelectListItem() { Text = $"{s.FirstName} {s.LastName}", Value = s.CustomerId.ToString() }).ToList();
            return View(result);
        }

        public ActionResult CreateTicket()
        {
            var customers = GetCustomers().Data;
            ViewBag.Customers = customers.Select(s => new SelectListItem() { Text = $"{s.FirstName} {s.LastName}", Value = s.CustomerId.ToString() }).ToList();
            return View(new Ticket() { Status = 1 });
        }

        private BaseResponse<Customer> GetCustomers()
        {
            return _restService.SendAsync<BaseResponse<Customer>>($"api/Customer", HttpMethod.Get);
        }

        [HttpPost]
        public ActionResult CreateTicket(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _restService.SendAsync<Ticket>("api/Ticket", HttpMethod.Post, ticket);
                return RedirectToAction("Index", "Ticket", new { customerId = ticket.CustomerId });
            }
            return View(ticket);
        }

        [HttpDelete]
        public IActionResult Delete(int id, int customerId)
        {
            bool isDeleted = _restService.SendAsync<bool>($"api/Ticket/{id}", HttpMethod.Delete);
            //Redirect to list page with refresh data
            return RedirectToAction("Index", "Ticket", new { customerId = customerId });
        }

        public ActionResult UpdateTicket(int id, int customerId)
        {
            var result = _restService.SendAsync<Ticket>($"api/Ticket/{id}", HttpMethod.Get);
            if (result == null)
            {
                return View(new Ticket() { CustomerId = customerId });
            }

            return View(result);
        }

        [HttpPost]
        public ActionResult UpdateTicket(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _restService.SendAsync<Ticket>($"api/Ticket/{ticket.TicketId}", HttpMethod.Put, ticket);
                return RedirectToAction("Index", "Ticket", new { customerId = ticket.CustomerId });
            }
            return View(ticket);
        }
    }
}