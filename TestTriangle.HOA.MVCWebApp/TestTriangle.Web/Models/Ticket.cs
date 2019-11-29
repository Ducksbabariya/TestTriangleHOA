using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTriangleHOA.Web.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please enter category")]
        public string Category { get; set; }
        public DateTime IssueStartedOn { get; set; }
        [Required(ErrorMessage = "Please enter status")]
        public byte Status { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 100;
    }
}
