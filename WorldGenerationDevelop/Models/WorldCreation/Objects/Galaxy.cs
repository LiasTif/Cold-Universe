#nullable enable
using System.Collections.ObjectModel;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Galaxy : BaseObject, ISuccessorIdsCollection
    {
        public ObservableCollection<int>? SuccessorIds { get; set; }
    }
}