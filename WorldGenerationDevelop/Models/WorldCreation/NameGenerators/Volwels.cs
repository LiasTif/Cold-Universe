namespace WorldGenerationDevelop.Models.WorldCreation.NameGenerators
{
    public class Volwels
    {
        private readonly RandomNumber _randomNumber = new RandomNumber();
        private readonly Diagraph _diagraph = new Diagraph();

        /// <summary>
        /// Коллекция согласных букв, пригодных для генерации названий
        /// </summary>
        public readonly string[] vowels = new string[6]
        {
            "Я", "О", "У", "А", "И", "Е"
        };

        /// <summary>
        /// get volwel from array and add diagraph
        /// </summary>
        /// <param name="IsStartOfSentence">It is a start of sentence?</param>
        /// <returns>volwel from array</returns>
        public string GetVolwel(bool IsStartOfSentence)
        {
            // vowels[GenRandomNum(1, x)
            // allows you not to use "Я" in the middle of a sentence
            string name = IsStartOfSentence ? vowels[_randomNumber.GenRandomNum(0, vowels.Length - 1)] :
                vowels[_randomNumber.GenRandomNum(1, vowels.Length - 1)].ToLower();
            return name.Remove(name.Length - 1, 1).Insert
                        (name.Length - 1, _diagraph.IsDigraph(name)).ToLower();
        }
    }
}
