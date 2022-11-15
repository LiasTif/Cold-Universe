namespace WorldGenerationDevelop.Models.WorldCreation.NameGenerators
{
    public class Volwels
    {
        private readonly RandomNumber _randomNum = new RandomNumber();
        private readonly Diagraph _diagraph = new Diagraph();

        /// <summary>
        /// Коллекция согласных букв, пригодных для генерации названий
        /// </summary>
        public readonly string[] vowels = new string[6]
        {
            "Я", "Е", "И", "У", "А", "О"
        };

        /// <summary>
        /// get volwel from array and add diagraph
        /// </summary>
        /// <param name="IsStartOfSentence">It is a start of sentence?</param>
        /// <returns>volwel from array</returns>
        public string GetVolwel(bool IsStartOfSentence, bool diagraph)
        {
            string name;
            if (diagraph)
            {
                name = IsStartOfSentence ? vowels[_randomNum.GenRandomNum(0, vowels.Length - 1)] :
                    vowels[_randomNum.GenRandomNum(1, vowels.Length - 1)].ToLower();
            }
            else
            {
                name = IsStartOfSentence ? vowels[_randomNum.GenRandomNum(0, vowels.Length - 1)] :
                    vowels[_randomNum.GenRandomNum(1, vowels.Length - 1)].ToLower(); // <-- vowels[GenRandomNum(4, x)
                                                                                     //                         ↑
                                                                                     // allows you not to use "Я" in the
                                                                                     // middle of a sentence

                // get last letter of the name
                string lastLetter = name.Substring(name.Length - 1);

                // insert diagraph if last letter are 'a' or 'o'
                if (lastLetter == "А" || lastLetter == "О")
                    name.Remove(name.Length - 1, 1).Insert
                        (name.Length - 1, _diagraph.IsDigraph(name));
            }
            return name;
        }
    }
}
