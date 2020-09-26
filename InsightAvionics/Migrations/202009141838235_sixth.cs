namespace InsightAvionics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.Updates", "UpdateImage", c => c.Binary());
            AddColumn("dbo.Updates", "UpdateImageTmp", c => c.Binary());
            Sql("Update dbo.Updates SET UpdateImageTmp = Convert(varbinary, UpdateImage)");
            DropColumn("dbo.Updates", "UpdateImage");
            RenameColumn("dbo.Updates", "UpdateImageTmp", "UpdateImage");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Updates", "UpdateImage", c => c.String());
        }
    }
}
