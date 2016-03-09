namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_To_Date : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sales", "PaymentTime", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "PaymentTime", c => c.DateTime(nullable: false));
        }
    }
}
