namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeValueType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewsPaperSizes", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.NewsPaperSizes", "Width", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.NewsPaperSizes", "NormalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.NewsPaperSizes", "PromotionalPrice", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewsPaperSizes", "PromotionalPrice", c => c.Double());
            AlterColumn("dbo.NewsPaperSizes", "NormalPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.NewsPaperSizes", "Width", c => c.Double(nullable: false));
            AlterColumn("dbo.NewsPaperSizes", "Height", c => c.Double(nullable: false));
        }
    }
}
