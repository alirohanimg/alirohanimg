using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.core.Entities
{
    public class SystemAdmin
    {
        public string Usernmae { get; set; }

        public SystemAdmin(string usernmae, string password, DateTime registerDate, string email, string fullName)
        {
            Usernmae = usernmae;
            Password = password;
            RegisterDate = registerDate;
            Email = email;
            FullName = fullName;
        }

        public string Password { get; set; }
        public string? MobileNumber { get; set; }
        public string FullName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }

        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }

    }
}
