using System.Data.Entity;
using WorldGenerationDevelop.Models.WorldCreation;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelop.Models
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("DbColdUniverseConnection")
        {
        }

        public DbSet<Galaxy> Galaxies { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<StarSystem> StarSystems { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Satellite> Satellites { get; set; }
        public DbSet<Asteroid> Asteroids { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<AsteroidField> AsteroidFields { get; set; }


        public DbSet<Description> Descriptions { get; set; }
    }
}