namespace WorldGenerationDevelop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateObjects : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StarSystems", "SectorId", "dbo.Sectors");
            DropIndex("dbo.StarSystems", new[] { "SectorId" });
            AlterColumn("dbo.StarSystems", "SectorId", c => c.Int());
            CreateIndex("dbo.StarSystems", "SectorId");
            AddForeignKey("dbo.StarSystems", "SectorId", "dbo.Sectors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StarSystems", "SectorId", "dbo.Sectors");
            DropIndex("dbo.StarSystems", new[] { "SectorId" });
            AlterColumn("dbo.StarSystems", "SectorId", c => c.Int(nullable: false));
            CreateIndex("dbo.StarSystems", "SectorId");
            AddForeignKey("dbo.StarSystems", "SectorId", "dbo.Sectors", "Id", cascadeDelete: true);
        }
    }
}
