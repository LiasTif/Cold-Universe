using System.Data.Entity;
using WorldGenerationDevelop.Models.WorldCreation;

namespace WorldGenerationDevelop.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbColdUniverseConnection")
        {
        }

        public DbSet<Galaxy> Galaxies { get; set; }
        public DbSet<StarSystem> StarSystems { get; set; }
    }
}