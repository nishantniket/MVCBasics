namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserPhonenumberAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserPhoneNumber", c => c.String(nullable: false, maxLength: 255));
        }

        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserPhoneNumber");
        }
    }
}
