using WorldGenerationDevelop.Models.WorldCreation.NameGenerators;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Stations
{
    /// <summary>
    /// generate station type
    /// </summary>
    public class StationTypeGenerator
    {
        #region properties
        private RandomNumber RandomNum { get; } = new RandomNumber();
        #endregion

        /// <summary>
        /// generate station type
        /// </summary>
        /// <returns>station type on string</returns>
        public string TypeGen()
        {
            return RandomNum.GenRandomNum(1, 5) switch
            {
                1 => "military base",
                2 => "research center",
                3 => "city station",
                4 => "shipyard",
                5 => "prison station",
                _ => "ERROR"
            };
        }
    }
}
