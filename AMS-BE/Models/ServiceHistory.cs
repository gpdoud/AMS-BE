using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS_BE.Models {
	public class ServiceHistory {
		public int Id { get; set; }

		public bool Active { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime? DateUpdated { get; set; }
	}
}