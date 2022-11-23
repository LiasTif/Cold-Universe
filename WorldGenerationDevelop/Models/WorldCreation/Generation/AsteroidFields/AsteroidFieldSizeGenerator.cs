using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.AsteroidFields
{
    /// <summary>
    /// generate size of asteroid field
    /// </summary>
    public class AsteroidFieldSizeGenerator
    {
        private RandomNumber RandomNum { get; } = new RandomNumber();

        /// <summary>
        /// start generate random size of asteroid field
        /// </summary>
        /// <returns>size on int</returns>
        public byte SizeGen()
        {
            return (byte)RandomNum.GenRandomNum(1,5);
        }
    }
}