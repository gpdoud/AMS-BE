namespace AMS_BE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUsermodelandcontroller : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Passsword = c.String(),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Department = c.String(),
                        Active = c.Boolean(nullable: false),
                        CanLogin = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateLastLogin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
