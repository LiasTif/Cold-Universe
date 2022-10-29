namespace WorldGenerationDevelop.Models.WorldCreation.NameGenerators
{
    public class Diagraph
    {
        private readonly RandomNumber _randomNumber = new RandomNumber();

        /// <summary>
        /// Returns the diagraph if the chance is triggered
        /// </summary>
        /// <param name="name">A line in which you can insert a diagraph</param>
        /// <returns>The last letter of a line or its repetition</returns>
        public string IsDigraph(string name)
        {
            // Chanse of diagraph
            if (_randomNumber.GenRandomNum(1, 40) > 38)
                name += (name[name.Length - 1]).ToString().ToLower();
            return name;
        }
    }
}
