using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Philoxenia.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string SurName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Afm { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;

        public string FullName => $"{LastName} {SurName}";

        public List<Booking> Bookings { get; set; }
    }

}
