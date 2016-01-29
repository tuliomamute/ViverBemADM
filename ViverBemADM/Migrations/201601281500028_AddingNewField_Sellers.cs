namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewField_Sellers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "SellerPhone", c => c.String());
            AddColumn("dbo.Sellers", "SellerEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sellers", "SellerEmail");
            DropColumn("dbo.Sellers", "SellerPhone");
        }
    }
}
