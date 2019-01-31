namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'033e9015-de34-4b2a-86e5-a847522551ac', N'admin@test.com', 0, N'AFv3dYj4DvgXAc1CvZtDTUFZV2dz116Oq0oWwlfUOjqphX9goWsCDMS987A8W9jslQ==', N'06294999-44d8-4eec-b5d9-7abbfea8389b', NULL, 0, 0, NULL, 1, 0, N'admin@test.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'51a0d459-dfb4-4c9f-86a6-eff70d64ef0a', N'guest@test.com', 0, N'AETftwchWTMSHnJ/fhACRwdnSCCZhAPx+cM7mHybYm61xABa3IOsIVCPOwJpFQgAFQ==', N'5d4adc9d-da2f-44d9-884a-3dc56fa1442a', NULL, 0, 0, NULL, 1, 0, N'guest@test.com')
    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f9fb37eb-887e-4759-84d7-6f6e33b593a7', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'033e9015-de34-4b2a-86e5-a847522551ac', N'f9fb37eb-887e-4759-84d7-6f6e33b593a7')

        ");
        }
        
        public override void Down()
        {
        }
    }
}
