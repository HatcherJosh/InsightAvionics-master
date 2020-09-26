namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProdShort", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProdShort");
        }
    }
}
