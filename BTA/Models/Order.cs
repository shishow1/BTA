using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTA.Models
{
    public class Order
    {
		public int OrderID { get; set; }
		public int VoyageID { get; set; }
		public string Status { get; set; }
	}
}
