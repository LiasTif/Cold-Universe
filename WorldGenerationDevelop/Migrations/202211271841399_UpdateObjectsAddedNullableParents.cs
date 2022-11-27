namespace WorldGenerationDevelop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateObjectsAddedNullableParents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AsteroidFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StarId = c.Int(nullable: false),
                        Size = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stars", t => t.StarId, cascadeDelete: true)
                .Index(t => t.StarId);
            
            CreateTable(
                "dbo.Fleets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StarId = c.Int(),
                        PlanetId = c.Int(),
                        SatelliteId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Satellites", t => t.SatelliteId)
                .ForeignKey("dbo.Planets", t => t.PlanetId)
                .ForeignKey("dbo.Stars", t => t.StarId)
                .Index(t => t.StarId)
                .Index(t => t.PlanetId)
                .Index(t => t.SatelliteId);
            
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StarId = c.Int(nullable: false),
                        StarSystemId = c.Int(nullable: false),
                        Temperature = c.String(),
                        PlanetType = c.String(),
                        Mass = c.String(),
                        AtmosphereType = c.Boolean(),
                        AsteroidsId_Id = c.Int(nullable: false),
                        FleetsId_Id = c.Int(nullable: false),
                        SatellitesId_Id = c.Int(nullable: false),
                        StationsId_Id = c.Int(nullable: false),
                        Star_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Asteroids", t => t.AsteroidsId_Id)
                .ForeignKey("dbo.Fleets", t => t.FleetsId_Id)
                .ForeignKey("dbo.Satellites", t => t.SatellitesId_Id)
                .ForeignKey("dbo.Stars", t => t.StarId)
                .ForeignKey("dbo.StarSystems", t => t.StarSystemId)
                .ForeignKey("dbo.Stations", t => t.StationsId_Id)
                .ForeignKey("dbo.Stars", t => t.Star_Id)
                .Index(t => t.StarId)
                .Index(t => t.StarSystemId)
                .Index(t => t.AsteroidsId_Id)
                .Index(t => t.FleetsId_Id)
                .Index(t => t.SatellitesId_Id)
                .Index(t => t.StationsId_Id)
                .Index(t => t.Star_Id);
            
            CreateTable(
                "dbo.Asteroids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StarId = c.Int(nullable: false),
                        PlanetId = c.Int(nullable: false),
                        SatelliteId = c.Int(nullable: false),
                        Size = c.Byte(),
                        Satellite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planets", t => t.PlanetId)
                .ForeignKey("dbo.Satellites", t => t.Satellite_Id)
                .ForeignKey("dbo.Satellites", t => t.SatelliteId)
                .ForeignKey("dbo.Stars", t => t.StarId)
                .Index(t => t.StarId)
                .Index(t => t.PlanetId)
                .Index(t => t.SatelliteId)
                .Index(t => t.Satellite_Id);
            
            CreateTable(
                "dbo.Satellites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        PlanetId = c.Int(nullable: false),
                        PlanetType = c.String(),
                        Temperature = c.String(),
                        AtmosphereType = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planets", t => t.PlanetId, cascadeDelete: true)
                .Index(t => t.PlanetId);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StarId = c.Int(),
                        PlanetId = c.Int(),
                        SatelliteId = c.Int(),
                        StationType = c.String(),
                        Size = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planets", t => t.PlanetId)
                .ForeignKey("dbo.Satellites", t => t.SatelliteId)
                .ForeignKey("dbo.Stars", t => t.StarId)
                .Index(t => t.StarId)
                .Index(t => t.PlanetId)
                .Index(t => t.SatelliteId);
            
            AddColumn("dbo.Stars", "StarSystemId", c => c.Int(nullable: false));
            AddColumn("dbo.StarSystems", "PlanetsId_Id", c => c.Int(nullable: false));
            AddColumn("dbo.StarSystems", "StarsId_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Stars", "StarSystemId");
            CreateIndex("dbo.StarSystems", "PlanetsId_Id");
            CreateIndex("dbo.StarSystems", "StarsId_Id");
            AddForeignKey("dbo.StarSystems", "PlanetsId_Id", "dbo.Planets", "Id");
            AddForeignKey("dbo.StarSystems", "StarsId_Id", "dbo.Stars", "Id");
            AddForeignKey("dbo.Stars", "StarSystemId", "dbo.StarSystems", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stars", "StarSystemId", "dbo.StarSystems");
            DropForeignKey("dbo.Planets", "Star_Id", "dbo.Stars");
            DropForeignKey("dbo.Fleets", "StarId", "dbo.Stars");
            DropForeignKey("dbo.Fleets", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.Planets", "StationsId_Id", "dbo.Stations");
            DropForeignKey("dbo.Planets", "StarSystemId", "dbo.StarSystems");
            DropForeignKey("dbo.StarSystems", "StarsId_Id", "dbo.Stars");
            DropForeignKey("dbo.StarSystems", "PlanetsId_Id", "dbo.Planets");
            DropForeignKey("dbo.Planets", "StarId", "dbo.Stars");
            DropForeignKey("dbo.Planets", "SatellitesId_Id", "dbo.Satellites");
            DropForeignKey("dbo.Planets", "FleetsId_Id", "dbo.Fleets");
            DropForeignKey("dbo.Planets", "AsteroidsId_Id", "dbo.Asteroids");
            DropForeignKey("dbo.Asteroids", "StarId", "dbo.Stars");
            DropForeignKey("dbo.Asteroids", "SatelliteId", "dbo.Satellites");
            DropForeignKey("dbo.Stations", "StarId", "dbo.Stars");
            DropForeignKey("dbo.Stations", "SatelliteId", "dbo.Satellites");
            DropForeignKey("dbo.Stations", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.Satellites", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.Fleets", "SatelliteId", "dbo.Satellites");
            DropForeignKey("dbo.Asteroids", "Satellite_Id", "dbo.Satellites");
            DropForeignKey("dbo.Asteroids", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.AsteroidFields", "StarId", "dbo.Stars");
            DropIndex("dbo.StarSystems", new[] { "StarsId_Id" });
            DropIndex("dbo.StarSystems", new[] { "PlanetsId_Id" });
            DropIndex("dbo.Stations", new[] { "SatelliteId" });
            DropIndex("dbo.Stations", new[] { "PlanetId" });
            DropIndex("dbo.Stations", new[] { "StarId" });
            DropIndex("dbo.Satellites", new[] { "PlanetId" });
            DropIndex("dbo.Asteroids", new[] { "Satellite_Id" });
            DropIndex("dbo.Asteroids", new[] { "SatelliteId" });
            DropIndex("dbo.Asteroids", new[] { "PlanetId" });
            DropIndex("dbo.Asteroids", new[] { "StarId" });
            DropIndex("dbo.Planets", new[] { "Star_Id" });
            DropIndex("dbo.Planets", new[] { "StationsId_Id" });
            DropIndex("dbo.Planets", new[] { "SatellitesId_Id" });
            DropIndex("dbo.Planets", new[] { "FleetsId_Id" });
            DropIndex("dbo.Planets", new[] { "AsteroidsId_Id" });
            DropIndex("dbo.Planets", new[] { "StarSystemId" });
            DropIndex("dbo.Planets", new[] { "StarId" });
            DropIndex("dbo.Fleets", new[] { "SatelliteId" });
            DropIndex("dbo.Fleets", new[] { "PlanetId" });
            DropIndex("dbo.Fleets", new[] { "StarId" });
            DropIndex("dbo.Stars", new[] { "StarSystemId" });
            DropIndex("dbo.AsteroidFields", new[] { "StarId" });
            DropColumn("dbo.StarSystems", "StarsId_Id");
            DropColumn("dbo.StarSystems", "PlanetsId_Id");
            DropColumn("dbo.Stars", "StarSystemId");
            DropTable("dbo.Stations");
            DropTable("dbo.Satellites");
            DropTable("dbo.Asteroids");
            DropTable("dbo.Planets");
            DropTable("dbo.Fleets");
            DropTable("dbo.AsteroidFields");
        }
    }
}
