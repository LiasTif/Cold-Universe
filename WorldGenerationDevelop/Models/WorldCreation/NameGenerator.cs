using System;
using System.Security.Cryptography;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    /// <summary>
    /// A class that generates object names
    /// </summary>
    public class NameGenerator
    {
        readonly Random rnd = new Random();

        /// <summary>
        /// Generate a name for the object
        /// </summary>
        /// <param name="type">Enter the type of the object</param>
        /// <returns>Name for the object</returns>
        public string GenerateName()
        {
            string actualName = "";
            int nameSize = GenRandomNum(3, 9);

            // Generating the beginning of a line with a vowel or consonant
            if (GenRandomNum(1, 2) != 1)
            {
                while (actualName.Length <= nameSize)
                {
                    actualName += consonants[GenRandomNum(0, consonants.Length - 1)];
                    actualName.Remove(actualName.Length - 1, 1).Insert(actualName.Length - 1, IsDigraph(actualName));

                    if (actualName.Length >= nameSize)
                        break;

                    actualName += vowels[GenRandomNum(0, vowels.Length - 1)];
                    actualName.Remove(actualName.Length - 1, 1).Insert(actualName.Length - 1, IsDigraph(actualName));
                }
            }
            else
            {
                while (actualName.Length <= nameSize)
                {
                    actualName += vowels[GenRandomNum(0, vowels.Length - 1)];
                    actualName.Remove(actualName.Length - 1, 1).Insert(actualName.Length - 1, IsDigraph(actualName));

                    if (actualName.Length >= nameSize)
                        break;

                    actualName += consonants[GenRandomNum(0, consonants.Length - 1)];
                    actualName.Remove(actualName.Length - 1, 1).Insert(actualName.Length - 1, IsDigraph(actualName));
                }
            }
            return actualName;
        }

        /// <summary>
        /// Returns the diagraph if the chance is triggered
        /// </summary>
        /// <param name="name">A line in which you can insert a diagraph</param>
        /// <returns>The last letter of a line or its repetition</returns>
        public string IsDigraph(string name)
        {
            // Chanse of diagraph
            if (GenRandomNum(1, 20) > 18)
            {
                name += (name[name.Length - 1]).ToString().ToLower();
            }
            return name;
        }

        /// <summary>
        /// Get random number
        /// </summary>
        /// <param name="min">Minimum number</param>
        /// <param name="max">Maximum number</param>
        /// <returns>Random number</returns>
        private int GenRandomNum(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        /// <summary>
        /// Коллекция согласных букв, пригодных для генерации названий
        /// </summary>
        private readonly string[] consonants = new string[15]
        { 
            "Б", "В", "Г", "Д", "З",
            "П", "Ф", "К", "Т", "С",
            "Л", "М", "Н", "Р", "Х"
        };

        /// <summary>
        /// Коллекция согласных букв, пригодных для генерации названий
        /// </summary>
        private readonly string[] vowels = new string[6]
        {
            "А", "О", "У", "Я", "И", "Е"
        };
    }
}