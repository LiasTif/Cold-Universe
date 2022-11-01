using System.Diagnostics;
using WorldGenerationDevelop.Models.WorldCreation;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelopTests
{
    public class WorldGenerationDevelopTests
    {
        [Fact]
        public void GenerateNamesList_list_ListOfNamesReturned()
        {
            NameGenerator nameGenerator = new();
            List<string> Result = new();

            for (int i = 0; i < 10; i++)
            {
                Result.Add(nameGenerator.GenerateName());
                Trace.WriteLine(Result[i]);
            }

            Assert.NotNull(Result);
            Assert.Equal(100, Result.Count);
        }

        [Fact]
        public void GenerateIdsCollection_collection_CollectionOfIdsReturned()
        {
            IdSetter idSetter = new();

            for (int i = 0; i < 100; i++)
            {
                idSetter.GetId();
            }

            Assert.Equal(1, idSetter.IdCollection[0]);
            Assert.Equal(100, idSetter.IdCollection[99]);
            Assert.Equal(100, idSetter.IdCollection.Count);
        }
    }
}