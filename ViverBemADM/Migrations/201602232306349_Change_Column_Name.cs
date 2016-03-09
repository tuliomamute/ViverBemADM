namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Column_Name : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Sales", name: "SaleSituationID", newName: "SalesSituationID");
            RenameIndex(table: "dbo.Sales", name: "IX_SaleSituationID", newName: "IX_SalesSituationID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Sales", name: "IX_SalesSituationID", newName: "IX_SaleSituationID");
            RenameColumn(table: "dbo.Sales", name: "SalesSituationID", newName: "SaleSituationID");
        }
    }
}
