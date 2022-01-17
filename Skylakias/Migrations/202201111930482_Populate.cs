namespace Skylakias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Monthly', 30, 1, 0.10)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Quarterly', 90, 3, 0.15)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Annual', 300, 12, 0.20)");

            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name]) VALUES (N'262d702b-49f3-44b7-9bda-58e69e32b9fa', N'admin@skylakias.com', 0, N'AC9PAqpdgxjuKmzGpcCUh1hXEoMtWH0nzqh1f6JLEJNAYz2Me3XV9r0aWB2+nuAE+A==', N'63a2f47a-796f-4890-b645-505fab9da246', NULL, 0, 0, NULL, 1, 0, N'admin@skylakias.com','Manolis Vordakis')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name]) VALUES (N'437bf912-aa7f-42d2-adbe-e09eee71eaf2', N'guest@skylakias.com', 0, N'AJQgC9CbXD9WVo/salxsl/0olWrzeBPC+IOIb+3e5gxUGNAH7EynzIf7EeHlhG/w3Q==', N'4b141618-039f-4893-b753-9c3454411283', NULL, 0, 0, NULL, 1, 0, N'guest@skylakias.com', 'Amfitryon Pinis')

                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b9f01797-1da5-44cc-80b0-18ed2e179ecf', N'Admin')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'262d702b-49f3-44b7-9bda-58e69e32b9fa', N'b9f01797-1da5-44cc-80b0-18ed2e179ecf')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
