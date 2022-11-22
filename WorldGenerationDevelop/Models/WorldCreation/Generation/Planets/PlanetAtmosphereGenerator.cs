using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    public class PlanetAtmosphereGenerator
    {
        /// <summary>
        /// Get Planet atmosphere
        /// </summary>
        /// <returns>Planet atmosphere on bool</returns>
        public bool GetPlanetTemperature()
        {
            RandomNumber randomNumber = new RandomNumber();

            return randomNumber.GenRandomNum(1, 2) switch
            {
                1 => true,
                _ => false
            };
        }
    }
}
