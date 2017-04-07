namespace RottenOrNot.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.Single(nullable: false),
                        Storyline = c.String(),
                        Film_Id = c.Int(),
                        User_Id = c.Int(),
                        User_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.Film_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.Film_Id)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.Serials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.Single(nullable: false),
                        Storyline = c.String(),
                        Serial_Id = c.Int(),
                        User_Id = c.Int(),
                        User_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Serials", t => t.Serial_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.Serial_Id)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Serials", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.Films", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.Serials", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Films", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Serials", "Serial_Id", "dbo.Serials");
            DropForeignKey("dbo.Films", "Film_Id", "dbo.Films");
            DropIndex("dbo.Serials", new[] { "User_Id1" });
            DropIndex("dbo.Serials", new[] { "User_Id" });
            DropIndex("dbo.Serials", new[] { "Serial_Id" });
            DropIndex("dbo.Films", new[] { "User_Id1" });
            DropIndex("dbo.Films", new[] { "User_Id" });
            DropIndex("dbo.Films", new[] { "Film_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Serials");
            DropTable("dbo.Films");
        }
    }
}
