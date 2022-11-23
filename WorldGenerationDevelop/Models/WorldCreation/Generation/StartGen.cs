using System.Collections.Generic;
using WorldGenerationDevelop.Models.WorldCreation.Generation.AsteroidFields;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Galaxies;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Planets;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Satellites;
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
        private SatelliteInitialization SatelliteInit { get; } = new SatelliteInitialization();
        private AsteroidFieldInitialization AsteroidFieldInit { get; } = new AsteroidFieldInitialization();

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
            using var context = new DbContext();

            Galaxy galaxy = GalaxyInit.GalaxyInit();

            var sectors = new List<Sector>();
            var starSystems = new List<StarSystem>();
            var stars = new List<Star>();
            var planets = new List<Planet>();
            var satellites = new List<Satellite>();
            var asteroidFields = new List<AsteroidField>();

            for (int S = 0; S < SizeOfGalaxy * 5; S++)
            {
                // generate sectors and add its to List
                Sector sector = SectorInit.SectorInit(galaxy);
                sectors.Add(sector);

                for (int ss = 0; ss < SizeOfGalaxy * 5; ss++)
                {
                    // generate star systems and add its to List
                    StarSystem starSystem = StarSystemInit.StarSystemInit(sector);
                    starSystems.Add(starSystem);

                    // generate star and add it to List
                    Star star = StarInit.StarInit(starSystem);
                    stars.Add(star);

                    // chanse to generate the asteroid field
                    if (randomNum.GenRandomNum(0,2) == 2)
                    {
                        // generate asteroid field and add it to List
                        AsteroidField asteroidField = AsteroidFieldInit.AsteroidFieldInit(star);
                        asteroidFields.Add(asteroidField);
                    }

                    for (int p = 0; p < randomNum.GenRandomNum(0, 8); p++)
                    {
                        // generate planet and add it to List
                        Planet planet = PlanetInit.PlanetInit(star);
                        planets.Add(planet);

                        for(int s = 0; s < randomNum.GenRandomNum(0, 5); s++)
                        {
                            // generate sattelite and add it ti List
                            Satellite satellite = SatelliteInit.SatelliteInit(planet);
                            satellites.Add(satellite);
                        }
                    }
                }
            }

            // add all Lists to DbContext
            context.Galaxies.Add(galaxy);
            context.Sectors.AddRange(sectors);
            context.StarSystems.AddRange(starSystems);
            context.Stars.AddRange(stars);
            context.Planets.AddRange(planets);
            context.Satellites.AddRange(satellites);
            context.AsteroidFields.AddRange(asteroidFields);

            context.SaveChanges();
        }
    }
}