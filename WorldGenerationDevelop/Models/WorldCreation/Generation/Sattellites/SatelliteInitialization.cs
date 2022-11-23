using System.Linq;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Planets;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Satellites
{
    /// <summary>
    /// initialize the satellite
    /// </summary>
    public class SatelliteInitialization
    {
        #region properties
        private NameGenerator NameGen { get; } = new NameGenerator();
        private PlanetTypeGenerator TypeGen { get; } = new PlanetTypeGenerator();
        private PlanetAtmosphereGenerator AtmosphereGen { get; } = new PlanetAtmosphereGenerator();
        private PlanetTemperatureGenerator TemperatureGen { get; } = new PlanetTemperatureGenerator();
        #endregion

        /// <summary>
        /// generate satellite
        /// </summary>
        /// <param name="parentPlanet"></param>
        /// <returns>initialized satellite</returns>
        public Satellite SatelliteInit(Planet parentPlanet)
        {
            using var context = new DbContext();
            var satelliteDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Satellite");

            // generate & save sattelite atmosphere to the buffer
            bool atmosphere = AtmosphereGen.GetPlanetAtmosphere();

            return new Satellite
            {
                Name = NameGen.GenerateName(),
                Description = satelliteDescription.Text,
                Temperature = TemperatureGen.GetPlanetTemperature(),
                Planet = parentPlanet,
                PlanetId = parentPlanet.Id,

                // use satellite atmosphere buffer
                AtmosphereType = atmosphere,
                PlanetType = TypeGen.GetPlanetType(atmosphere)
            };
        }
    }
}