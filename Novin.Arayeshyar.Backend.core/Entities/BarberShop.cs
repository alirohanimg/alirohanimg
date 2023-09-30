using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.core.Entities
{
    public class BarberShop
    {
        public int ID  { get; set; }
        public string Password { get; set; }
        public string? FullName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime RegisterDate { get; set; }
        public  string PostalCode  { get; set; }

        public BarberShop(string postalCode, string tel, DateTime registerDate, string city, string state, string address, int iD, string password)
        {
            PostalCode = postalCode;
            Tel = tel;
            RegisterDate = registerDate;
            City = city;
            State = state;
            Address = address;
            ID = iD;
            Password = password;
        }

        public string Tel { get; set; }
        public string Address { get; set; }
    }
}
