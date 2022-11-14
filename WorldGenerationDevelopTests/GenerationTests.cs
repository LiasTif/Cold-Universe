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
            GalaxyAccess galaxyAccess = new();
            StarSystemAccess starSystemAccess = new();
            StarSystemInitialization starSystemInit = new();

            Assert.NotNull(galaxyAccess.GetGalaxy(0));
            Assert.NotNull(starSystemAccess.GetStarSystem(0));

            //for (int i = 1; i < 6; i++)
            //    Assert.NotNull(starSystemInit.GetStarSystem(i));
        }
    }
}