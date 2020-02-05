namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'803dc31f-6d84-4592-8c0c-e663d4624d36', N'guest@vidly.com', 0, N'ALjJqWW1MsYgyjRgN61Oa/9aoIofBvwOjs2IZ6Czz42HizsaO101FnOUJHllV64w3w==', N'99058202-c33c-44ad-90f8-1d3feea2f27b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2253e8f-3fe3-46c3-8b69-e8991cca96c9', N'admin@vidly.com', 0, N'AOe+A/zILh3uo45QNU8b2BJhnCXLUvZ3DstyYL4IIf3F3U+xk2x60ADhpPGoinf36w==', N'7a71e77f-58a7-4330-a737-0fdf0abe37c1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0d425c8d-6151-48ea-947a-e2cb9ce80df1', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f2253e8f-3fe3-46c3-8b69-e8991cca96c9', N'0d425c8d-6151-48ea-947a-e2cb9ce80df1')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
