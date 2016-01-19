namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetSomeFieldsToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewsPaperSizes", "PromotionalPrice", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewsPaperSizes", "PromotionalPrice", c => c.Double(nullable: false));
        }
    }
}
