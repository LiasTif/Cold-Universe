namespace WorldGenerationDevelop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galaxies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StarSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StarSystems");
            DropTable("dbo.Galaxies");
        }
    }
}
