#nullable enable
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Station : BaseObject, IType, ISize
    {
        public string? Type { get; set; }
        public byte? Size { get; set; }
    }
}