namespace Skylakias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStaff : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [MembershipTypeId], [Birthdate], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'60192089-eab3-4f9d-8b3d-20da3a86d419', N'Angelos Rap', 1, NULL, N'angelos@skylakias.com', 0, N'AKO0KfLvjgGS+G0AWOeGkS4yV4JYl9hOjvSAdBTEDNySGdqEq4qllDfggCO0A2c5mw==', N'8c4ee07a-84fc-4f2d-b85a-07e7c7c710c6', NULL, 0, 0, NULL, 1, 0, N'angelos@skylakias.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c10afb6d-4c8a-4c6b-af75-abd4743d2eb4', N'Staff')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'60192089-eab3-4f9d-8b3d-20da3a86d419', N'c10afb6d-4c8a-4c6b-af75-abd4743d2eb4')
        ");
        }
        
        public override void Down()
        {
        }
    }
}
