using System;

namespace WorldGenerationDevelop.Models.WorldCreation.NameGenerators
{
    public class RandomNumber
    {
        readonly Random rnd = new Random();

        /// <summary>
        /// Get random number
        /// </summary>
        /// <param name="min">Minimum number</param>
        /// <param name="max">Maximum number</param>
        /// <returns>Random number</returns>
        public int GenRandomNum(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }
    }
}
