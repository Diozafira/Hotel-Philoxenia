using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Philoxenia.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }  // e.g., Single, Double, Suite
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Hotel Hotel { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
