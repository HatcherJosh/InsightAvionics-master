namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "ProdImage");
            AddColumn("dbo.Products", "ProdImage", c => c.Binary());
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image", c => c.Binary());
            DropColumn("dbo.Products", "ProdImage");
        }
    }
}
