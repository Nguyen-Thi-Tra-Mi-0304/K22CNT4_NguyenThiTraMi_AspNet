using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nttm_Lab04.Models
{
    public class NttmCustomer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public int YearOfBirth { get; set; }

    }
}