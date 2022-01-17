namespace Skylakias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DateStarted", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "DateStarted");
        }
    }
}
