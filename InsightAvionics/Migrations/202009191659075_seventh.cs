namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Updates", "UpdateHeading", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Updates", "UpdateHeading");
        }
    }
}
