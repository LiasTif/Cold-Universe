using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    public class PlanetInitialization
    {
        private NameGenerator NameGen { get; } = new NameGenerator();
        private PlanetTypeGenerator PlanetTypeGen { get; } = new PlanetTypeGenerator();
        private PlanetMassGenerator PlanetMassGen { get; } = new PlanetMassGenerator();

        /// <summary>
        /// generate planet
        /// </summary>
        /// <param name="parentStar"></param>
        /// <returns>initialized planet</returns>
        public Planet PlanetInit(Star parentStar)
        {
            using var context = new MyDbContext();
            var planetDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Planet");

            // generate & save planet mass to the buffer
            string mass = PlanetMassGen.GetPlanetMass();

            return new Planet
            {
                Name = NameGen.GenerateName(),
                Description = planetDescription.Text,
                // use planet mass buffer
                Mass = mass,
                PlanetType = PlanetTypeGen.GetPlanetType(mass),

                AtmosphereType = 
            };
        }
    }
}