using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTriangleHOA.Web.Models
{
    public class Customer
    {
        public Customer()
        {

        }

        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter firstname")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Required(ErrorMessage = "Please select country")]
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 100;

    }
}
