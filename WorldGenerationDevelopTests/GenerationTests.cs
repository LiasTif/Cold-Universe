using WorldGenerationDevelop.Models;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelopTests
{
    public class GenerationTests
    {
        [Fact]
        public void StartGeneration_DbTables_NANReturned()
        {
            GalaxyInitialization galaxyInit = new();
            StarSystemInitialization starSystemInit = new();

            Assert.NotNull(galaxyInit.GetGalaxy(1));

            for (int i = 0; i < 6; i++)
                Assert.NotNull(starSystemInit.GetStarSystem(i));
        }
    }
}