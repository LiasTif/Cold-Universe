using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Stars
{
    public class StarTypeGenerator
    {
        /// <summary>
        /// Get Star type(class from O to Y)
        /// </summary>
        /// <returns>Star type on char</returns>
        public char GetStarType()
        {
            RandomNumber randomNumber = new RandomNumber();

            return randomNumber.GenRandomNum(1, 12) switch
            {
                1  => 'O',
                2  => 'B',
                3  => 'A',
                4  => 'F',
                5  => 'G',
                6  => 'K',
                7  => 'M',
                8  => 'C',
                9  => 'S',
                10 => 'L',
                11 => 'T',
                _  => 'Y',
            };
        }
    }
}