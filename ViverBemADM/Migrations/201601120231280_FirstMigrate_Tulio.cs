namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrate_Tulio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ContactName = c.String(),
                        ContactPhone = c.String(),
                        ContactEmail = c.String(),
                        CNPJ = c.String(),
                        StateInscrition = c.String(),
                        TownInscrition = c.String(),
                    })
                .PrimaryKey(t => t.ClientID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SalesID = c.Int(nullable: false, identity: true),
                        SaleValue = c.Double(nullable: false),
                        PaymentTime = c.Int(nullable: false),
                        SaleSituation = c.Int(nullable: false),
                        SellerPercentage = c.Int(nullable: false),
                        NumberOfEdition = c.Int(nullable: false),
                        YearOfEdition = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        PaymentFormID = c.Int(nullable: false),
                        SellersID = c.Int(nullable: false),
                        NewsPaperSizesID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.NewsPaperSizes", t => t.NewsPaperSizesID, cascadeDelete: true)
                .ForeignKey("dbo.PaymentForms", t => t.PaymentFormID, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellersID, cascadeDelete: true)
                .Index(t => t.ClientID)
                .Index(t => t.PaymentFormID)
                .Index(t => t.SellersID)
                .Index(t => t.NewsPaperSizesID);
            
            CreateTable(
                "dbo.NewsPaperSizes",
                c => new
                    {
                        NewsPaperSizesID = c.Int(nullable: false, identity: true),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        NormalPrice = c.Double(nullable: false),
                        PromotionalPrice = c.Double(nullable: false),
                        SizeName = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.NewsPaperSizesID);
            
            CreateTable(
                "dbo.PaymentForms",
                c => new
                    {
                        PaymentFormID = c.Int(nullable: false, identity: true),
                        PaymentFormName = c.String(),
                    })
                .PrimaryKey(t => t.PaymentFormID);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellersID = c.Int(nullable: false, identity: true),
                        SellerName = c.String(),
                    })
                .PrimaryKey(t => t.SellersID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "SellersID", "dbo.Sellers");
            DropForeignKey("dbo.Sales", "PaymentFormID", "dbo.PaymentForms");
            DropForeignKey("dbo.Sales", "NewsPaperSizesID", "dbo.NewsPaperSizes");
            DropForeignKey("dbo.Sales", "ClientID", "dbo.Clients");
            DropIndex("dbo.Sales", new[] { "NewsPaperSizesID" });
            DropIndex("dbo.Sales", new[] { "SellersID" });
            DropIndex("dbo.Sales", new[] { "PaymentFormID" });
            DropIndex("dbo.Sales", new[] { "ClientID" });
            DropTable("dbo.Sellers");
            DropTable("dbo.PaymentForms");
            DropTable("dbo.NewsPaperSizes");
            DropTable("dbo.Sales");
            DropTable("dbo.Clients");
        }
    }
}
