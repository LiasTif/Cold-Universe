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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asteroid>()
                .HasRequired(c => c.Planet)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Asteroid>()
                .HasRequired(c => c.Star)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Asteroid>()
                .HasRequired(c => c.Satellite)
                .WithMany()
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Planet>()
                .HasRequired(c => c.StarSystem)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Planet>()
                .HasRequired(c => c.Star)
                .WithMany()
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Planet>()
            //    .HasRequired(c => c.SatellitesId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Planet>()
            //    .HasRequired(c => c.FleetsId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Planet>()
            //    .HasRequired(c => c.AsteroidsId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Planet>()
            //    .HasRequired(c => c.StationsId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<StarSystem>()
            //    .HasRequired(c => c.PlanetsId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<StarSystem>()
            //    .HasRequired(c => c.StarsId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);


            //modelBuilder.Entity<Star>()
            //    .HasRequired(c => c.PlanetsId)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
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