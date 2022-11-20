using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Stars
{
    public class StarInitialization
    {
        private NameGenerator NameGen { get; } = new NameGenerator();

        /// <summary>
        /// generate star
        /// </summary>
        /// <param name="parentStarSystem"></param>
        /// <returns>initialized star</returns>
        public Star StarInit(StarSystem parentStarSystem)
        {
            StarTypeGenerator starTypeGenerator = new StarTypeGenerator();
            using var context = new MyDbContext();
            var starDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Star");

            return new Star
            {
                Name = NameGen.GenerateName(),
                Description = starDescription.Text,
                Type = starTypeGenerator.GetStarType()
            };
        }
    }
}
