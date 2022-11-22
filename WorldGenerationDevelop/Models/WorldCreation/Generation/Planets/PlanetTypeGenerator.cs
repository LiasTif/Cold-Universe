using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Planets
{
    public class PlanetTypeGenerator
    {
        /// <summary>
        /// Get Planet type on string
        /// </summary>
        /// <returns>Planet type</returns>
        public string GetPlanetType(string mass, bool atmosphere)
        {
            RandomNumber randomNumber = new RandomNumber();

            if (mass == "earth type" && atmosphere)
            {
                return randomNumber.GenRandomNum(1, 9) switch
                {
                    1 => "primitive life forms",
                    2 => "advanced life forms",
                    3 => "intelligent life forms",
                    4 => "primitive society",
                    5 => "ancient world",
                    6 => "iddle Ages",
                    7 => "modern times",
                    8 => "space technologies",
                    9 => "ecumenopolis",
                    _ => "ERROR"
                };
            }

            return mass switch
            {
                "earth type" => randomNumber.GenRandomNum(1, 2) switch
                {
                    1 => "radioactive wasteland",
                    2 => "wasteland",
                    _ => "ERROR"
                },
                "giant" => "giant",
                "ice giant" => "ice giant",
                "dwarf planet" => "dwarf planet",
                _ => "ERROR"
            };
    }
}
}