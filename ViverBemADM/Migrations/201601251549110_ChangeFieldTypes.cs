namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFieldTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "ContactName", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "ContactPhone", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "ContactEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "CNPJ", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "CNPJ", c => c.String());
            AlterColumn("dbo.Clients", "ContactEmail", c => c.String());
            AlterColumn("dbo.Clients", "ContactPhone", c => c.String());
            AlterColumn("dbo.Clients", "ContactName", c => c.String());
            AlterColumn("dbo.Clients", "Address", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
