using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nttm_Lab04_1.Models
{
    public class NttmCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
}