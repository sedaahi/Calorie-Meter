namespace Calorie_Meter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Protein = c.Double(nullable: false),
                        CarboHydrate = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Calorie = c.Double(nullable: false),
                        ImagePath = c.String(),
                        CountOfTotalEating = c.Int(nullable: false),
                        CountOfEatingBreakfeast = c.Int(nullable: false),
                        CountOfEatingLunch = c.Int(nullable: false),
                        CountOfEatingDinner = c.Int(nullable: false),
                        CountOfEatingSnack = c.Int(nullable: false),
                        CategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoriId, cascadeDelete: true)
                .Index(t => t.CategoriId);
            
            CreateTable(
                "dbo.RepastFoodDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        TotalCalorieDetail = c.Double(nullable: false),
                        TotalProteinDetail = c.Double(nullable: false),
                        TotalFatDetail = c.Double(nullable: false),
                        TotalCarboHydrateDetail = c.Double(nullable: false),
                        Portion = c.Int(nullable: false),
                        RepastId = c.Int(nullable: false),
                        FoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .ForeignKey("dbo.Repasts", t => t.RepastId, cascadeDelete: true)
                .Index(t => t.RepastId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Repasts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        RepastName = c.Int(nullable: false),
                        Date = c.DateTime(),
                        TotalCalorieRepast = c.Double(nullable: false),
                        TotalProteinRepast = c.Double(nullable: false),
                        TotalFatRepast = c.Double(nullable: false),
                        TotalCarboHydrateRepast = c.Double(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        EMail = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepastFoodDetails", "RepastId", "dbo.Repasts");
            DropForeignKey("dbo.Repasts", "UserId", "dbo.Users");
            DropForeignKey("dbo.RepastFoodDetails", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoriId", "dbo.Categories");
            DropIndex("dbo.Repasts", new[] { "UserId" });
            DropIndex("dbo.RepastFoodDetails", new[] { "FoodId" });
            DropIndex("dbo.RepastFoodDetails", new[] { "RepastId" });
            DropIndex("dbo.Foods", new[] { "CategoriId" });
            DropTable("dbo.Users");
            DropTable("dbo.Repasts");
            DropTable("dbo.RepastFoodDetails");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
