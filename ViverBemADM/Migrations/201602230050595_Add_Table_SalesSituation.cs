namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_SalesSituation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesSituations",
                c => new
                    {
                        SalesSituationID = c.Int(nullable: false, identity: true),
                        SituationName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SalesSituationID);
            
            AddColumn("dbo.Sales", "SaleSituationID", c => c.Int(nullable: false));
            CreateIndex("dbo.Sales", "SaleSituationID");
            AddForeignKey("dbo.Sales", "SaleSituationID", "dbo.SalesSituations", "SalesSituationID", cascadeDelete: true);
            DropColumn("dbo.Sales", "SaleSituation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "SaleSituation", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sales", "SaleSituationID", "dbo.SalesSituations");
            DropIndex("dbo.Sales", new[] { "SaleSituationID" });
            DropColumn("dbo.Sales", "SaleSituationID");
            DropTable("dbo.SalesSituations");
        }
    }
}
