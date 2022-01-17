namespace Skylakias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceToService : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Orders", "TotalPrice", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "TotalPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Int(nullable: false));
            DropColumn("dbo.Services", "Price");
        }
    }
}
