namespace WorldGenerationDevelop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGalaxySuccessorsId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StarSystems", "Galaxy_Id", c => c.Int());
            CreateIndex("dbo.StarSystems", "Galaxy_Id");
            AddForeignKey("dbo.StarSystems", "Galaxy_Id", "dbo.Galaxies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StarSystems", "Galaxy_Id", "dbo.Galaxies");
            DropIndex("dbo.StarSystems", new[] { "Galaxy_Id" });
            DropColumn("dbo.StarSystems", "Galaxy_Id");
        }
    }
}
