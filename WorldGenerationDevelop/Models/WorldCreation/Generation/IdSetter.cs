using System.Collections.ObjectModel;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public static class IdSetter
    {
        public static ObservableCollection<int> IdCollection { get; private set; }

        public static int GetId()
        {
            if (IdCollection == null)
                IdCollection = new ObservableCollection<int> { 1 };
            else
                IdCollection.Add(IdCollection.Count + 1);

            return IdCollection[IdCollection.Count - 1];
        }
    }
}