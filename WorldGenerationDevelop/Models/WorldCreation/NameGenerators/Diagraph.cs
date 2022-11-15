namespace WorldGenerationDevelop.Models.WorldCreation.NameGenerators
{
    public class Diagraph
    {
        private readonly RandomNumber _randomNum = new RandomNumber();

        /// <summary>
        /// Returns the diagraph if the chance is triggered
        /// </summary>
        /// <param name="name">A line in which you can insert a diagraph</param>
        /// <returns>The last letter of a line or its repetition</returns>
        public string IsDigraph(string name)
        {
            // Chanse of diagraph
            if (_randomNum.GenRandomNum(1, 30) > 28)
                name += (name[name.Length - 1]).ToString().ToLower();

            // turn off next diagraph on the current name
            NameGenerator.Diagraph = true;

            return name;
        }
    }
}
