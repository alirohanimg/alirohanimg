using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.core.Entities
{
    public class Customer
    {
        public string MobileNumber{ get; set; }

        public Customer(string mobileNumber, DateTime registerDate)
        {
            MobileNumber = mobileNumber;
            RegisterDate = registerDate;
        }

        public string? Password { get; set; }
        public string? Fullnmae { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set;}
        public string? City { get; set; }
        public string? State { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
