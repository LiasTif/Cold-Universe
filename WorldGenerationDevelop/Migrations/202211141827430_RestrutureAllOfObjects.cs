namespace WorldGenerationDevelop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestrutureAllOfObjects : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StarSystems", "Galaxy_Id", "dbo.Galaxies");
            DropIndex("dbo.StarSystems", new[] { "Galaxy_Id" });
            CreateTable(
                "dbo.Sectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        GalaxyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Galaxies", t => t.GalaxyId, cascadeDelete: true)
                .Index(t => t.GalaxyId);
            
            AddColumn("dbo.StarSystems", "SectorId", c => c.Int(nullable: false));
            CreateIndex("dbo.StarSystems", "SectorId");
            AddForeignKey("dbo.StarSystems", "SectorId", "dbo.Sectors", "Id", cascadeDelete: true);
            DropColumn("dbo.StarSystems", "Galaxy_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StarSystems", "Galaxy_Id", c => c.Int());
            DropForeignKey("dbo.StarSystems", "SectorId", "dbo.Sectors");
            DropForeignKey("dbo.Sectors", "GalaxyId", "dbo.Galaxies");
            DropIndex("dbo.StarSystems", new[] { "SectorId" });
            DropIndex("dbo.Sectors", new[] { "GalaxyId" });
            DropColumn("dbo.StarSystems", "SectorId");
            DropTable("dbo.Sectors");
            CreateIndex("dbo.StarSystems", "Galaxy_Id");
            AddForeignKey("dbo.StarSystems", "Galaxy_Id", "dbo.Galaxies", "Id");
        }
    }
}
