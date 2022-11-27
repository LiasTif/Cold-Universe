using System.Collections.Generic;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Asteroids;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Stations;
using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class SmallObjectsGeneration
    {
        #region properties
        private AsteroidInitialization AsteroidInit { get; } = new AsteroidInitialization();
        private StationInitialization StationInit { get; } = new StationInitialization();
        private RandomNumber RandomNum { get; } = new RandomNumber();
        #endregion

        /// <summary>
        /// Generate small child objects(asteroids and stations) for Parent object
        /// </summary>
        /// <param name="parentStar">Star object, parent for generated objects</param>
        /// <param name="asteroids">List with Asteroids</param>
        /// <param name="stations">List with Stations</param>
        /// <param name="maxRandAsteroids">the minimum possible number of generated stations</param>
        /// <param name="maxRandStations">the maximum possible number of generated stations</param>
        public void GenerateSmallObjects(object parent,
            ref List<Asteroid> asteroids, ref List<Station> stations,
            int maxRandAsteroids, int maxRandStations,
            bool populatedSystem)
        {
            Asteroid asteroid = null;
            Station station = null;

            // random asteroids generation
            for (int i = 0; i < RandomNum.GenRandomNum(0, maxRandAsteroids); i++)
            {
                if (parent is Star star)
                    asteroid = AsteroidInit.AsteroidInit(star);
                else if (parent is Planet planet)
                    asteroid = AsteroidInit.AsteroidInit(planet);
                else if (parent is Satellite satellite)
                    asteroid = AsteroidInit.AsteroidInit(satellite);

                if (asteroid != null)
                    asteroids.Add(asteroid);
            }

            if (populatedSystem)
            {
                // random stations generation
                for (int i = 0; i < RandomNum.GenRandomNum(0, maxRandStations); i++)
                {
                    if (parent is Star star)
                        station = StationInit.StationInit(star);
                    else if (parent is Planet planet)
                        station = StationInit.StationInit(planet);
                    else if (parent is Satellite satellite)
                        station = StationInit.StationInit(satellite);

                    if (station != null)
                        stations.Add(station);
                }
            }
        }
    }
}
