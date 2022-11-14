using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Planet : IBase, ITemperature, IType, IColonizedLevel
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        public byte Temperature { get; set; }
        public string Type { get; set; }
        public byte ColonizedLevel { get; set; }
    }
}