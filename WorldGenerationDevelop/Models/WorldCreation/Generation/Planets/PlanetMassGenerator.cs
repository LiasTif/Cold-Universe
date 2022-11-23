using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    public class PlanetMassGenerator
    {
        /// <summary>
        /// Get Planet mass on string
        /// </summary>
        /// <returns>Planet mass on string</returns>
        public string GetPlanetMass()
        {
            RandomNumber randomNum = new RandomNumber();

            return randomNum.GenRandomNum(1, 4) switch
            {
                1 => "earth type",
                2 => "giant",
                3 => "ice giant",
                4 => "dwarf planet",
                _ => "ERROR"
            };
        }
    }
}
