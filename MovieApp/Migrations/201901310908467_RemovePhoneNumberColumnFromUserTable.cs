namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePhoneNumberColumnFromUserTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
ALTER TABLE AspNetUsers DROP CONSTRAINT DF__AspNetUse__UserP__5BE2A6F2
ALTER TABLE AspNetUsers DROP column UserPhoneNumber");
        }
        
        public override void Down()
        {
        }
    }
}
