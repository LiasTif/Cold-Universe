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
            using var context = new MyDbContext();

            Galaxy galaxy = new Galaxy
            {
                Name = NameGen.GenerateName()
            };

            context.Galaxies.Add(galaxy);
            context.SaveChanges();

            return galaxy;
        }
    }
}