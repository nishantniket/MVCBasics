namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPhoneNumberToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserPhoneNumber", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserPhoneNumber");
        }
    }
}
