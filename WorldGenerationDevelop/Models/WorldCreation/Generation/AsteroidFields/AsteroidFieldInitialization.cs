using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.AsteroidFields
{
    /// <summary>
    /// initialize the asteroid field
    /// </summary>
    public class AsteroidFieldInitialization
    {
        private NameGenerator NameGen { get; } = new NameGenerator();
        private AsteroidFieldSizeGenerator SizeGen { get; } = new AsteroidFieldSizeGenerator();

        /// <summary>
        /// generate asteroid field
        /// </summary>
        /// <param name="parentStar"></param>
        /// <returns>initialized asteroid field</returns>
        public AsteroidField AsteroidFieldInit(Star parentStar)
        {
            using var context = new DbContext();
            var asteroidFieldDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "AsteroidField");

            return new AsteroidField
            {
                Name = NameGen.GenerateName(),
                Description = asteroidFieldDescription.Text,
                Size = SizeGen.SizeGen(),
                Star = parentStar,
                StarId = parentStar.Id
            };
        }
    }
}
