using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTA.Models
{
    public class Ticket
    {
		public int TicketID { get; set; }
		public int OrderID { get; set; }
		public string DocNumber { get; set; }
		public int SeatNumber { get; set; }
		public string Status { get; set; }
	}
}
