namespace LeadsStates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String());
            AddColumn("dbo.AspNetUsers", "CNIC", c => c.String());
            AddColumn("dbo.AspNetUsers", "SelaryType", c => c.String());
            AddColumn("dbo.AspNetUsers", "SelaryAmount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SelaryAmount");
            DropColumn("dbo.AspNetUsers", "SelaryType");
            DropColumn("dbo.AspNetUsers", "CNIC");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "MobileNumber");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
