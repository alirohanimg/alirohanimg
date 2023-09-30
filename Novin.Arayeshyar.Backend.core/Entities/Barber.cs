using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.core.Entities
{
    public class Barber
    {
        public string MobileNumber { get; set; }

        public Barber(string mobileNumber, string password, string fullName, string city, string state, DateTime registerDate)
        {
            MobileNumber = mobileNumber;
            Password = password;
            FullName = fullName;
            City = city;
            State = state;
            RegisterDate = registerDate;
        }

        public string Password { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string? Email { get; set; }
        public DateTime RegisterDate { get; set; }

        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }
    }
}
