using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTA.Models
{
    public class User
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EMail { get; set; }
		public string Password { get; set; }
		public DateTime BirthDate { get; set; }

	}
}
