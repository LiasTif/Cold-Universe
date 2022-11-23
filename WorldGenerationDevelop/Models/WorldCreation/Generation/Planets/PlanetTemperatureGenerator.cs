using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    public class PlanetTemperatureGenerator
    {
        /// <summary>
        /// Get Planet temperature
        /// </summary>
        /// <returns>Planet temperature on char</returns>
        public string GetPlanetTemperature()
        {
            RandomNumber randomNum = new RandomNumber();

            return randomNum.GenRandomNum(1, 7) switch
            {
                1 => "hot",
                2 => "very warm",
                3 => "warm",
                4 => "cool",
                5 => "cold",
                6 => "very cold",
                7 => "icy",
                _ => "ERROR"
            };
        }
    }
}
