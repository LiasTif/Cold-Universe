namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Galaxies
{
    public class GalaxyInitialization
    {
        public NameGenerator NameGen { get; } = new NameGenerator();

        /// <summary>
        /// initialize galaxy
        /// </summary>
        public Galaxy GalaxyInit()
        {
            return new Galaxy { Name = NameGen.GenerateName() };
        }
    }
}