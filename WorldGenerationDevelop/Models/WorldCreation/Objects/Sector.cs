#nullable enable
using System.Collections.ObjectModel;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Sector : BaseObject, IParentId, ISuccessorIdsCollection
    {
        public int ParentId { get; set; }
        public ObservableCollection<int>? SuccessorIds { get; set; }
    }
}
