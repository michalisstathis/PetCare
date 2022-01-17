namespace Skylakias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedServices : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Services] ON");
            Sql("INSERT INTO[dbo].[Services] ([Id], [Name], [Description], [Price]) VALUES(1, N'Dog Walking', N'Choose from a 30, 45, or 60-minute visit to give your pet their daily dose of fun-filled exercise', CAST(10.0000 AS Money))");
            Sql("INSERT INTO[dbo].[Services] ([Id], [Name], [Description], [Price]) VALUES(2, N'Pet Grooming', N'Our grooming specialists are trained and experienced in bathing, trimming, and styling most breed types', CAST(15.0000 AS Money))");
            Sql("INSERT INTO[dbo].[Services] ([Id], [Name], [Description], [Price]) VALUES(3, N'Dog Training', N'Dog training is the act of teaching a dog particular skills or behaviors', CAST(25.0000 AS Money))");
            Sql("INSERT INTO[dbo].[Services] ([Id], [Name], [Description], [Price]) VALUES(4, N'Pet Sitting', N'Book a 5-star sitter to take care of your dog and your home', CAST(50.0000 AS Money))");
            Sql("SET IDENTITY_INSERT[dbo].[Services] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
