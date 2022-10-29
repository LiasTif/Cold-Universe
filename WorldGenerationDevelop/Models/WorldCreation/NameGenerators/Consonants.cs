namespace WorldGenerationDevelop.Models.WorldCreation.NameGenerators
{
    public class Consonants
    {
        private readonly RandomNumber _randomNumber = new RandomNumber();
        private readonly Diagraph _diagraph = new Diagraph();

        /// <summary>
        /// Коллекция согласных букв, пригодных для генерации названий
        /// </summary>
        public readonly string[] consonants = new string[15]
        {
            "Б", "В", "Г", "Д", "З",
            "П", "Ф", "К", "Т", "С",
            "Л", "М", "Н", "Р", "Х"
        };

        /// <summary>
        /// get consonant from array and add diagraph
        /// </summary>
        /// <param name="isLowerChapter">put the consonant in lower case?</param>
        /// <returns>consonant from array</returns>
        public string GetConsonants(bool isLowerChapter)
        {
            string name = isLowerChapter ? consonants[_randomNumber.GenRandomNum
                (0, consonants.Length - 1)].ToLower() :
                consonants[_randomNumber.GenRandomNum(0, consonants.Length - 1)];

            return name.Remove(name.Length - 1, 1).Insert
                        (name.Length - 1, _diagraph.IsDigraph(name)).ToLower();
        }
    }
}