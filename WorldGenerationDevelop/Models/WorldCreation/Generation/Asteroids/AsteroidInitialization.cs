using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Asteroids
{
    /// <summary>
    /// initialize the Asteroid
    /// </summary>
    public class AsteroidInitialization
    {
        #region properties
        private NameGenerator NameGen { get; } = new NameGenerator();
        private AsteroidSizeGenerator SizeGen { get; } = new AsteroidSizeGenerator();
        #endregion

        /// <summary>
        /// generate asteroid
        /// </summary>
        /// <param name="parentStar">Star, parrent object</param>
        /// <returns>initialized asteroid</returns>
        public Asteroid AsteroidInit(Star parentStar)
        {
            using var context = new DbContext();
            var AsteroidDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Asteroid");

            return new Asteroid
            {
                Name = NameGen.GenerateName(),
                Description = AsteroidDescription.Text,
                Size = SizeGen.SizeGen(),
                Star = parentStar,
                StarId = parentStar.Id
            };
        }

        /// <summary>
        /// generate asteroid
        /// </summary>
        /// <param name="parentPlanet">Planet, parrent object</param>
        /// <returns>initialized asteroid</returns>
        public Asteroid AsteroidInit(Planet parentPlanet)
        {
            using var context = new DbContext();
            var AsteroidDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Asteroid");

            return new Asteroid
            {
                Name = NameGen.GenerateName(),
                Description = AsteroidDescription.Text,
                Size = SizeGen.SizeGen(),
                Planet = parentPlanet,
                PlanetId = parentPlanet.Id
            };
        }

        /// <summary>
        /// generate asteroid
        /// </summary>
        /// <param name="parentSatellite">Satellite, parrent object</param>
        /// <returns>initialized asteroid</returns>
        public Asteroid AsteroidInit(Satellite parentSatellite)
        {
            using var context = new DbContext();
            var AsteroidDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Asteroid");

            return new Asteroid
            {
                Name = NameGen.GenerateName(),
                Description = AsteroidDescription.Text,
                Size = SizeGen.SizeGen(),
                Satellite = parentSatellite,
                SatelliteId = parentSatellite.Id
            };
        }
    }
}
