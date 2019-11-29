using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestTriangleHOA.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestTriangleHOA.Web.Service;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestTriangleHOA.Web.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private RestService _restService;

        public CustomerController(RestService restService)
        {
            _restService = restService;
        }

        // GET: /<controller>/
        public IActionResult Index(int page = 1, int pageSize = 50)
        {
            var result = _restService.SendAsync<BaseResponse<Customer>>($"api/Customer?page={page}&pageSize={pageSize}", HttpMethod.Get);
            return View(result);
        }

        public ActionResult CreateCustomer()
        {
            return View(new Customer());
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _restService.SendAsync<Customer>("api/Customer", HttpMethod.Post, customer);
                return RedirectToAction("Index", "Customer");
            }
            return View(customer);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            bool isDeleted = _restService.SendAsync<bool>($"api/Customer/{id}", HttpMethod.Delete);
            //Redirect to list page with refresh data
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult UpdateCustomer(int id)
        {
            var result = _restService.SendAsync<Customer>($"api/Customer/{id}", HttpMethod.Get);
            if (result == null)
            {
                return View(new Customer());
            }

            return View(result);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _restService.SendAsync<Customer>($"api/Customer/{customer.CustomerId}", HttpMethod.Put, customer);
                return RedirectToAction("Index", "Customer");
            }
            return View(customer);
        }

    }
}
