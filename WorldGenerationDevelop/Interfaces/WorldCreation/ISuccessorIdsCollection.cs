using System.Collections.ObjectModel;

namespace WorldGenerationDevelop.Interfaces.WorldCreation
{
    public interface ISuccessorIdsCollection
    {
        ObservableCollection<int> SuccessorIds { get; set; }
    }
}