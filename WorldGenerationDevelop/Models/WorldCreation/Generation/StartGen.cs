using System.Collections.Generic;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Galaxies;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Sectors;
using WorldGenerationDevelop.Models.WorldCreation.Generation.StarSystems;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StartGen
    {
        public GalaxyInitialization GalaxyInit { get; } = new GalaxyInitialization();
        public SectorInitialization SectorInit { get; } = new SectorInitialization();
        public StarSystemInitialization StarSystemInit { get; } = new StarSystemInitialization();

        /// <summary>
        /// numerical indicator of the size of the galaxy
        /// </summary>
        public int SizeOfGalaxy { private get; set; } = 1;

        /// <summary>
        /// start generation
        /// </summary>
        public void GenerateWorld()
        {
            using var context = new MyDbContext();

            Galaxy galaxy = GalaxyInit.GalaxyInit();

            var sectors = new List<Sector>();
            var starSystems = new List<StarSystem>();

            for (int S = 0; S < SizeOfGalaxy * 5; S++)
            {
                // generate sectors and add its to DbContext
                Sector sector = SectorInit.SectorInit(galaxy);
                sectors.Add(sector);

                for (int ss = 0; ss < SizeOfGalaxy * 5; ss++)
                {
                    // generate star systems and add its to DbContext
                    StarSystem starSystem = StarSystemInit.StarSystemInit(sector);
                    starSystems.Add(starSystem);
                }
            }

            context.Galaxies.Add(galaxy);
            context.Sectors.AddRange(sectors);
            context.StarSystems.AddRange(starSystems);

            context.SaveChanges();
        }
    }
}