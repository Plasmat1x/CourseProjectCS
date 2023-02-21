namespace CourseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemModify : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "MakerFK");
            DropColumn("dbo.Items", "TypeFK");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "TypeFK", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "MakerFK", c => c.Int(nullable: false));
        }
    }
}
