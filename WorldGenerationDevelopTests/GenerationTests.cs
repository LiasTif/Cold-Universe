using WorldGenerationDevelop.Models.WorldCreation.Generation;
using WorldGenerationDevelop.Models.WorldCreation;

namespace WorldGenerationDevelopTests
{
    public class GenerationTests
    {
        [Fact]
        public void GenerateIdsCollection_collection_CollectionOfIdsReturned()
        {
            for (int i = 0; i < 99; i++)
            {
                IdSetter.GetId();
            }

            Assert.Equal(1, IdSetter.IdCollection[0]);
            Assert.Equal(100, IdSetter.IdCollection[99]);
            Assert.Equal(100, IdSetter.IdCollection.Count);
        }

        [Fact]
        public void StartGeneration_object_GalaxyObjectReturned()
        {
            StartGen startGen = new();
            Galaxy galaxy = startGen.GetGalaxy();

            Assert.Equal(1, galaxy.Id);
            Assert.NotEmpty(galaxy.Name);
        }
    }
}
