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
            try
            {
                var result = _restService.SendAsync<BaseResponse<Customer>>($"api/Customer?page={page}&pageSize={pageSize}", HttpMethod.Get);
                return View(result);
            }
            catch (Exception ex)
            {
                return Error();
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            _restService.SendAsync<Customer>("api/Customer", HttpMethod.Post, customer);
            return RedirectToAction("Index", "Customer");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _restService.SendAsync<bool>($"api/Customer/{id}", HttpMethod.Delete);
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Update(int id)
        {
            var result = _restService.SendAsync<Customer>($"api/Customer/{id}", HttpMethod.Get);
            return View(result);
        }

        [HttpPut]
        public ActionResult UpdateCustomer(Customer customer)
        {
            _restService.SendAsync<Customer>($"api/Customer/{customer.CustomerId}", HttpMethod.Put, customer);
            return RedirectToAction("Index", "Customer");
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
