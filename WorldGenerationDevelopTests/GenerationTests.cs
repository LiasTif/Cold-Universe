using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelopTests
{
    public class GenerationTests
    {
        [Fact]
        public void StartGeneration_DbTables_NANReturned()
        {
            GalaxyInitialization galaxyInitialization = new GalaxyInitialization();
            StartGen startGen = new();

            Assert.NotNull(galaxyInitialization.Galaxy);
        }
    }
}
