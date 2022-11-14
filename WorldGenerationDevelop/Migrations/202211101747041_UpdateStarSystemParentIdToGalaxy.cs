namespace WorldGenerationDevelop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStarSystemParentIdToGalaxy : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StarSystems", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StarSystems", "ParentId", c => c.Int(nullable: false));
        }
    }
}
