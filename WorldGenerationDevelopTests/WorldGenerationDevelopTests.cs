using System.Diagnostics;
using WorldGenerationDevelop.Models.WorldCreation;

namespace WorldGenerationDevelopTests
{
    public class WorldGenerationDevelopTests
    {
        [Fact]
        public void GenerateNamesList_list_ListOfNamesReturned()
        {
            NameGenerator nameGenerator = new();
            List<string> Result = new();

            for (int i = 0; i < 100; i++)
            {
                Result.Add(nameGenerator.GenerateName());
                Trace.WriteLine(Result[i]);
            }

            Assert.NotNull(Result);
            Assert.Equal(100, Result.Count);
        }
    }
}