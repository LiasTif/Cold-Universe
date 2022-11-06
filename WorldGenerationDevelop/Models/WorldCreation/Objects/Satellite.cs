#nullable enable
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Satellite : BaseObject, IParentId, IType, ITemperature, IColonizedLevel
    {
        public int ParentId { get; set; }
        public string? Type { get; set; }
        public byte? Temperature { get; set; }
        public byte? ColonizedLevel { get; set; }
    }
}
