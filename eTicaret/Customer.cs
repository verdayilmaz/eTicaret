using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret
{
    public class Customer
    {

        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Identity { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsCompany { get; set; }
        public string CompanyName { get; set; }


    }
}
