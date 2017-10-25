namespace AMS_BE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetUserfieldstringlimitsanddefaultvaluesforbooleansanddates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Firstname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Lastname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Department", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.Users", "DateLastLogin", c => c.DateTime());
            DropColumn("dbo.Users", "Passsword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Passsword", c => c.String());
            AlterColumn("dbo.Users", "DateLastLogin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Department", c => c.String());
            AlterColumn("dbo.Users", "Lastname", c => c.String());
            AlterColumn("dbo.Users", "Firstname", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            DropColumn("dbo.Users", "Password");
        }
    }
}
