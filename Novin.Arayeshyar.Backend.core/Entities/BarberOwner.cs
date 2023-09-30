using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.core.Entities
{
    public class BarberOwner
    {
        public  string MobileNumber  { get; set; }

        public BarberOwner(string mobileNumber, string password, string fullName, DateTime registerDate, string email)
        {
            MobileNumber = mobileNumber;
            Password = password;
            FullName = fullName;
            RegisterDate = registerDate;
            Email = email;
        }

        public string Password { get; set; }
        public string FullName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }

        public DateTime? BirthDate  { get; set; }
        public string? Address { get; set; }





    }
}
