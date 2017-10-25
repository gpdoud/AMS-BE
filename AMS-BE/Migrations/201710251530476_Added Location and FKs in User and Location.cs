namespace AMS_BE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationandFKsinUserandLocation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "LocationId", c => c.Int());
            CreateIndex("dbo.Users", "LocationId");
            AddForeignKey("dbo.Users", "LocationId", "dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "LocationId", "dbo.Locations");
            DropIndex("dbo.Users", new[] { "LocationId" });
            DropColumn("dbo.Users", "LocationId");
            DropTable("dbo.Locations");
        }
    }
}
