#nullable enable
using System.Collections.ObjectModel;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Planet : BaseObject, IParentId, ITemperature, IType, IColonizedLevel, ISuccessorIdsCollection
    {
        public int ParentId { get; set; }
        public byte? Temperature { get; set; }
        public string? Type { get; set; }
        public byte? ColonizedLevel { get; set; }
        public ObservableCollection<int>? SuccessorIds { get; set; }
    }
}