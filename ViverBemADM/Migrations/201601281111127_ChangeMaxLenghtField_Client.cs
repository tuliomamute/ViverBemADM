namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMaxLenghtField_Client : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "ContactName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "ContactName", c => c.String(nullable: false));
        }
    }
}
