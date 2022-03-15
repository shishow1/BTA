using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTA.Models
{
    public class Voyage
    {
		public int ID { get; set; }
		public int DepartureBusStopID { get; set; }
		public int ArrivalBusStopID { get; set; }
		public DateTime DepartureDateAndTime { get; set; }
		public DateTime ArrivalDateAndTime { get; set; }
		public DateTime TravelTime { get; set; }
		public int VoyageNumber { get; set; }
		public string VoyageName { get; set; }
		public int NumberOfSeats { get; set; }
		public decimal OneTicketCost { get; set; }
	}
}
