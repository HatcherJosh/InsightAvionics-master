namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ninth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SideProducts",
                c => new
                    {
                        SideID = c.Int(nullable: false, identity: true),
                        SideName = c.String(nullable: false),
                        SideShort = c.String(nullable: false),
                        SideImage = c.Binary(),
                        SideBody = c.String(),
                    })
                .PrimaryKey(t => t.SideID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SideProducts");
        }
    }
}
