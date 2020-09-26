namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProdBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProdBody");
        }
    }
}
