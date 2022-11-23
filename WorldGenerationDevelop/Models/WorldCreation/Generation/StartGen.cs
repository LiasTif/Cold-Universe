using System.Collections.Generic;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Galaxies;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Planets;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Sectors;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Stars;
using WorldGenerationDevelop.Models.WorldCreation.Generation.StarSystems;
using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StartGen
    {
        #region properties
        
        private GalaxyInitialization GalaxyInit { get; } = new GalaxyInitialization();
        private SectorInitialization SectorInit { get; } = new SectorInitialization();
        private StarSystemInitialization StarSystemInit { get; } = new StarSystemInitialization();
        private StarInitialization StarInit { get;  } = new StarInitialization();
        private PlanetInitialization PlanetInit { get; } = new PlanetInitialization();

        /// <summary>
        /// numerical indicator of the size of the galaxy
        /// </summary>
        public int SizeOfGalaxy { private get; set; } = 1;

        #endregion

        readonly RandomNumber randomNum = new RandomNumber();

        /// <summary>
        /// start generation
        /// </summary>
        public void GenerateWorld()
        {
            using var context = new MyDbContext();

            Galaxy galaxy = GalaxyInit.GalaxyInit();

            var sectors = new List<Sector>();
            var starSystems = new List<StarSystem>();
            var stars = new List<Star>();
            var planets = new List<Planet>();

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

                    // generate star and add it to DbContext
                    Star star = StarInit.StarInit(starSystem);
                    stars.Add(star);

                    for (int p = 0; p < randomNum.GenRandomNum(0,8); p++)
                    {
                        // generate planet and add it to DbContext
                        Planet planet = PlanetInit.PlanetInit(star);
                        planets.Add(planet);
                    }
                }
            }

            context.Galaxies.Add(galaxy);
            context.Sectors.AddRange(sectors);
            context.StarSystems.AddRange(starSystems);
            context.Stars.AddRange(stars);
            context.Planets.AddRange(planets);

            context.SaveChanges();
        }
    }
}