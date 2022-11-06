#nullable enable
using System.Collections.ObjectModel;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Star : BaseObject, IParentId, ISuccessorIdsCollection, IType
    {
        public int ParentId { get; set; }
        public string? Type { get; set; }
        public ObservableCollection<int>? SuccessorIds { get; set; }
    }
}
