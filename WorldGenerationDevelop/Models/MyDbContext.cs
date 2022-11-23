using System.Data.Entity;
using WorldGenerationDevelop.Models.WorldCreation;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelop.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbColdUniverseConnection")
        {
        }

        public DbSet<Galaxy> Galaxies { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<StarSystem> StarSystems { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Planet> Planets { get; set; }
    }
}