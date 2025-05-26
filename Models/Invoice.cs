using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Philoxenia.Models
{
    internal class Invoice
    {
        public class InvoiceModel
        {
            public int InvoiceId { get; set; }
            public string CustomerFullName { get; set; }
            public string CustomerAFM { get; set; }
            public int BookingId { get; set; }
            public double TotalCost { get; set; }
        }

    }
}
