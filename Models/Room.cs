using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Philoxenia.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }  // e.g., Single, Double, Suite
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerNight { get;  set; }
        
        public bool IsAvailable { get; set; }
        
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        [NotMapped]
        public string HotelName => Hotel?.Name;
        public List<Booking> Bookings { get; set; }
        
    }
}
