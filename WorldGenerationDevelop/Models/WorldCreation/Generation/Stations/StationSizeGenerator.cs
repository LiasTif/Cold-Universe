using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Stations
{
    /// <summary>
    /// generate station size
    /// </summary>
    public class StationSizeGenerator
    {
        #region properties
        private RandomNumber randomNum { get; } = new RandomNumber();
        #endregion

        /// <summary>
        /// generate station size
        /// </summary>
        /// <returns>station size on byte value</returns>
        public byte SizeGen()
        {
            return (byte)randomNum.GenRandomNum(1, 7);
        }
    }
}
