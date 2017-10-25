namespace AMS_BE.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AMS_BE.Models.AMS_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AMS_BE.Models.AMS_Context context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
			context.Locations.AddOrUpdate(
				l => l.Description,
				new Models.Location { Description = "Corp", Address = "123 Any Street",
					Phone = "513-555-1212", Email = "corp@township.com",
					Active = true }
			);
			context.Users.AddOrUpdate(
				u => u.Username,
				new Models.User {
					Username = "superadmin", Password = "pass@word1",
					Firstname = "Super", Lastname = "Admin", Department = "Corp",
					LocationId = context.Locations.SingleOrDefault(l => l.Description.ToLower().Equals("corp")).Id,
					Active = true, CanLogin = true, DateCreated = DateTime.Now }
			);
		}
    }
}
