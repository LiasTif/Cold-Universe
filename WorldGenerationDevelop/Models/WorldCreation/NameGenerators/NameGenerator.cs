using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    /// <summary>
    /// A class that generates object names
    /// </summary>
    public class NameGenerator
    {
        private readonly Consonants _consonants = new Consonants();
        private readonly Volwels _volwels = new Volwels();
        private readonly RandomNumber _randomNum = new RandomNumber();

        /// <summary>
        /// Generate a name for the object
        /// </summary>
        /// <param name="type">Enter the type of the object</param>
        /// <returns>Name for the object</returns>
        public string GenerateName()
        {
            string actualName = "";
            int nameSize = _randomNum.GenRandomNum(3, 9);

            // Generating the beginning of a line with a vowel or consonant
            if (_randomNum.GenRandomNum(1, 2) != 1)
            {
                actualName += _consonants.GetConsonants(false);

                while (actualName.Length <= nameSize)
                {
                    actualName += _volwels.GetVolwel(false);

                    if (actualName.Length >= nameSize)
                        break;

                    actualName += _consonants.GetConsonants(true);
                }
            }
            else
            {
                actualName += _volwels.GetVolwel(true);

                while (actualName.Length <= nameSize)
                {
                    actualName += _consonants.GetConsonants(true);

                    if (actualName.Length >= nameSize)
                        break;

                    actualName += _volwels.GetVolwel(false);
                }
            }
            return actualName;
        }
    }
}