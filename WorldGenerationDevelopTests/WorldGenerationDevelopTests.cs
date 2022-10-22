using System.Diagnostics;
using WorldGenerationDevelop.Models.WorldCreation;

namespace WorldGenerationDevelopTests
{
    public class WorldGenerationDevelopTests
    {
        [Fact]
        public void GenerateDiagraph_string_TwoSameLettersReturned()
        {
            NameGenerator nameGenerator = new();
            string result = nameGenerator.IsDigraph("B");
            string? expectedResult;

            if (result.Length == 2)
                expectedResult = result[0].ToString() + result[0].ToString().ToLower();
            else if (result.Length == 1)
                expectedResult = result;
            else
                expectedResult = null;

            Assert.NotNull(result);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GenerateNamesList_list_ListOfNamesReturned()
        {
            NameGenerator nameGenerator = new();
            List<string> Result = new();

            for (int i = 0; i < 11; i++)
            {
                Result.Add(nameGenerator.GenerateName());
                Trace.WriteLine(Result[i]);
            }

            Assert.NotNull(Result);
            Assert.Equal(10, Result.Count);
        }
    }
}