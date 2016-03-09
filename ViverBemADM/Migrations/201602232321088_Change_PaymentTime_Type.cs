namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_PaymentTime_Type : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sales", "PaymentTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "PaymentTime", c => c.Int(nullable: false));
        }
    }
}
