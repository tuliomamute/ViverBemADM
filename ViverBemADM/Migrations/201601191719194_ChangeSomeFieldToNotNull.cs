namespace ViverBemADM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSomeFieldToNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewsPaperSizes", "SizeName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewsPaperSizes", "SizeName", c => c.String(maxLength: 30));
        }
    }
}
