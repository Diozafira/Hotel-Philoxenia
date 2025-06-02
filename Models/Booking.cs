using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Philoxenia.Models
{
    public class Booking
    {

        
        
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int RoomId { get; set; }
        public DateTime ReservationDateFrom { get; set; }
        public DateTime ReservationDateTo { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public bool Canceled { get; set; }
        public double ReservationDayPrice { get; set; }
        public Room Room { get; set; }
        public Customer Customer { get; set; }
    }

}
