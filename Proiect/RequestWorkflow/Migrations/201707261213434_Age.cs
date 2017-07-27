namespace RequestWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Age : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Image", c => c.String());
        }
    }
}
