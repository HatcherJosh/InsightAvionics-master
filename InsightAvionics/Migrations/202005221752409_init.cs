namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProdID = c.Int(nullable: false, identity: true),
                        ProdName = c.String(nullable: false),
                        ProdImage = c.String(),
                        ProdDesc = c.String(nullable: false),
                        ProductUpdateVM_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ProdID)
                .ForeignKey("dbo.ProductUpdateVMs", t => t.ProductUpdateVM_ID)
                .Index(t => t.ProductUpdateVM_ID);
            
            CreateTable(
                "dbo.ProductUpdateVMs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Updates",
                c => new
                    {
                        UpdateID = c.Int(nullable: false, identity: true),
                        UpdateName = c.String(nullable: false),
                        UpdateImage = c.String(),
                        UpdateBody = c.String(nullable: false),
                        posted = c.DateTime(nullable: false),
                        ProductUpdateVM_ID = c.Int(),
                    })
                .PrimaryKey(t => t.UpdateID)
                .ForeignKey("dbo.ProductUpdateVMs", t => t.ProductUpdateVM_ID)
                .Index(t => t.ProductUpdateVM_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Updates", "ProductUpdateVM_ID", "dbo.ProductUpdateVMs");
            DropForeignKey("dbo.Products", "ProductUpdateVM_ID", "dbo.ProductUpdateVMs");
            DropIndex("dbo.Updates", new[] { "ProductUpdateVM_ID" });
            DropIndex("dbo.Products", new[] { "ProductUpdateVM_ID" });
            DropTable("dbo.Updates");
            DropTable("dbo.ProductUpdateVMs");
            DropTable("dbo.Products");
        }
    }
}
