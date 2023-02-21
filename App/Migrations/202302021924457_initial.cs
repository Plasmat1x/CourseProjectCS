namespace CourseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemCountries",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        QuantityId = c.Int(nullable: false),
                        FailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemId, t.CountryId })
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Fails", t => t.FailId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Quantities", t => t.QuantityId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.CountryId)
                .Index(t => t.QuantityId)
                .Index(t => t.FailId);
            
            CreateTable(
                "dbo.Fails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Model = c.String(),
                        MakerFK = c.Int(nullable: false),
                        TypeFK = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Release = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Maker_Id = c.Int(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makers", t => t.Maker_Id)
                .ForeignKey("dbo.Types", t => t.Type_Id)
                .Index(t => t.Maker_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Makers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sellings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quantities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemCountries", "QuantityId", "dbo.Quantities");
            DropForeignKey("dbo.Items", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Sellings", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "Maker_Id", "dbo.Makers");
            DropForeignKey("dbo.ItemCountries", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemCountries", "FailId", "dbo.Fails");
            DropForeignKey("dbo.ItemCountries", "CountryId", "dbo.Countries");
            DropIndex("dbo.Sellings", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "Type_Id" });
            DropIndex("dbo.Items", new[] { "Maker_Id" });
            DropIndex("dbo.ItemCountries", new[] { "FailId" });
            DropIndex("dbo.ItemCountries", new[] { "QuantityId" });
            DropIndex("dbo.ItemCountries", new[] { "CountryId" });
            DropIndex("dbo.ItemCountries", new[] { "ItemId" });
            DropTable("dbo.Quantities");
            DropTable("dbo.Types");
            DropTable("dbo.Sellings");
            DropTable("dbo.Makers");
            DropTable("dbo.Items");
            DropTable("dbo.Fails");
            DropTable("dbo.ItemCountries");
            DropTable("dbo.Countries");
        }
    }
}
