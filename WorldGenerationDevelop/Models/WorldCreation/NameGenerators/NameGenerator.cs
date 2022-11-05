using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    /// <summary>
    /// A class that generates object names
    /// </summary>
    public class NameGenerator
    {
        private Consonants Consonants { get; } = new Consonants();
        private Volwels Volwels { get; } = new Volwels();
        private RandomNumber RandomNum { get; } = new RandomNumber();


        /// <summary>
        /// Generate a name for the object
        /// </summary>
        /// <param name="type">Enter the type of the object</param>
        /// <returns>Name for the object</returns>
        public string GenerateName()
        {
            string actualName = "";
            int nameSize = RandomNum.GenRandomNum(3, 9);

            // Generating the beginning of a line with a vowel or consonant
            if (RandomNum.GenRandomNum(1, 2) != 1)
            {
                actualName += Consonants.GetConsonants(false);

                while (actualName.Length <= nameSize)
                {
                    actualName += Volwels.GetVolwel(false);

                    if (actualName.Length >= nameSize)
                        break;

                    actualName += Consonants.GetConsonants(true);
                }
            }
            else
            {
                actualName += Volwels.GetVolwel(true);

                while (actualName.Length <= nameSize)
                {
                    actualName += Consonants.GetConsonants(true);

                    if (actualName.Length >= nameSize)
                        break;

                    actualName += Volwels.GetVolwel(false);
                }
            }
            return actualName;
        }
    }
}