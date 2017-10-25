using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AMS_BE.Models
{
    public class AMS_Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AMS_Context() : base("name=AMS_Context")
        {
        }

		public System.Data.Entity.DbSet<AMS_BE.Models.User> Users { get; set; }

		public System.Data.Entity.DbSet<AMS_BE.Models.Location> Locations { get; set; }
	}
}
