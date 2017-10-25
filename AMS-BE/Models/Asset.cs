using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AMS_BE.Models {
	public class Asset {
		public int Id { get; set; }
		public DateTime? DatePurchased { get; set; }
		[StringLength(30)]
		[Required]
		public string PO { get; set; }
		public double? Cost { get; set; }
		[StringLength(30)]
		[Required]
		public string BudgetCenter { get; set; }
		[ForeignKey("User")]
		public User AssignedToUser { get; set; }
		[StringLength(30)]
		[Required]
		public string DepartmentName { get; set; }
		public DateTime? DateOutForRepair { get; set; }
		public DateTime? DateReturnedToService { get; set; }
		[StringLength(30)]
		public string ReasonForRepair { get; set; }
		public string HistoryOfChange { get; set; } // don't know what this is
		public DateTime? DateRetired { get; set; }
		public DateTime? DateSurplused { get; set; }
		public DateTime? DateDisposed { get; set; }
		public double? ResidualValue { get; set; }
	}
}