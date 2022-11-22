#nullable enable
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Star : IBase
    {
        #region Base
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        #endregion

        public char? StarType { get; set; }
    }
}
