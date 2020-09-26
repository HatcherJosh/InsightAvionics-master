namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProdSplash", c => c.Binary());
            AddColumn("dbo.Products", "ProdPromo", c => c.Binary());
            DropColumn("dbo.Products", "ProdImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProdImage", c => c.String());
            DropColumn("dbo.Products", "ProdPromo");
            DropColumn("dbo.Products", "ProdSplash");
        }
    }
}
