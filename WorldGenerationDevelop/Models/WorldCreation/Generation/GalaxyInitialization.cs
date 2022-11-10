namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class GalaxyInitialization
    {
        public NameGenerator NameGen { get; } = new NameGenerator();

        /// <summary>
        /// current galaxy
        /// </summary>
        public Galaxy Galaxy { get; private set; } = new Galaxy();


        /// <summary>
        /// initialize galaxy
        /// </summary>
        public void GalaxyInit()
        {
            using var context = new MyDbContext();

            Galaxy.Name = NameGen.GenerateName();
            context.Galaxies.Add(Galaxy);
            context.SaveChanges();
        }
    }
}