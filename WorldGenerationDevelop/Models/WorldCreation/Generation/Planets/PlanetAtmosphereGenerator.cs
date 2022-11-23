using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    public class PlanetAtmosphereGenerator
    {
        /// <summary>
        /// Get Planet atmosphere
        /// </summary>
        /// <returns>Planet atmosphere on bool</returns>
        public bool GetPlanetAtmosphere()
        {
            RandomNumber randomNum = new RandomNumber();

            return randomNum.GenRandomNum(1, 2) switch
            {
                1 => true,
                _ => false
            };
        }
    }
}
