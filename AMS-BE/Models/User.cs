using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AMS_BE.Models {
	public class User {
		public int Id { get; set; }
		[StringLength(30)]
		[Required]
		public string Username { get; set; }
		[StringLength(30)]
		[Required]
		public string Password { get; set; }
		[StringLength(30)]
		[Required]
		public string Firstname { get; set; }
		[StringLength(30)]
		[Required]
		public string Lastname { get; set; }
		[StringLength(50)]
		[Required]
		public string Department { get; set; }

		public int? LocationId { get; set; }
		public virtual Location Location { get; set; }

		public bool Active { get; set; } = true;
		public bool CanLogin { get; set; } = false;
		public DateTime DateCreated { get; set; } = DateTime.Now;
		public DateTime? DateUpdated { get; set; }
		public DateTime? DateLastLogin { get; set; }
	}
}