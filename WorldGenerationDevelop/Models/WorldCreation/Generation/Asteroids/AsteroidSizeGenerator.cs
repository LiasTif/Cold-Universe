using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Asteroids
{
    /// <summary>
    /// generate size of asteroid
    /// </summary>
    public class AsteroidSizeGenerator
    {
        private RandomNumber RandomNum { get; } = new RandomNumber();

        /// <summary>
        /// start generate random size of asteroid
        /// </summary>
        /// <returns>size on int</returns>
        public byte SizeGen()
        {
            return (byte)RandomNum.GenRandomNum(1, 3);
        }
    }
}
