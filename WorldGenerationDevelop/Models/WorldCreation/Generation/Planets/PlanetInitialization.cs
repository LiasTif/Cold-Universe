using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    /// <summary>
    /// initialize the planet
    /// </summary>
    public class PlanetInitialization
    {
        private NameGenerator NameGen { get; } = new NameGenerator();
        private PlanetTypeGenerator TypeGen { get; } = new PlanetTypeGenerator();
        private PlanetMassGenerator MassGen { get; } = new PlanetMassGenerator();
        private PlanetAtmosphereGenerator AtmosphereGen { get; } = new PlanetAtmosphereGenerator();
        private PlanetTemperatureGenerator TemperatureGen { get; } = new PlanetTemperatureGenerator();

        /// <summary>
        /// generate planet
        /// </summary>
        /// <param name="parentStar"></param>
        /// <returns>initialized planet</returns>
        public Planet PlanetInit(Star parentStar)
        {
            using var context = new DbContext();
            var planetDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Planet");

            // generate & save planet mass and atmosphere to the buffer
            string mass = MassGen.GetPlanetMass();
            bool atmosphere = AtmosphereGen.GetPlanetAtmosphere();

            return new Planet
            {
                Name = NameGen.GenerateName(),
                Description = planetDescription.Text,
                Temperature = TemperatureGen.GetPlanetTemperature(),
                Star = parentStar,
                StarId = parentStar.Id,

                // use planet mass and atmosphere buffer
                Mass = mass,
                AtmosphereType = atmosphere,
                PlanetType = TypeGen.GetPlanetType(mass, atmosphere)
            };
        }
    }
}