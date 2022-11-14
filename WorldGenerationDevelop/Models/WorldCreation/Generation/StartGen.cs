namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StartGen
    {
        public GalaxyInitialization GalaxyInit { get; } = new GalaxyInitialization();
        public StarSystemInitialization StarSystemInit { get; } = new StarSystemInitialization();


        /// <summary>
        /// numerical indicator of the size of the galaxy
        /// </summary>
        public int SizeOfGalaxy { private get; set; }


        /// <summary>
        /// start generation
        /// </summary>
        public void StartGeneration()
        {
            GalaxyInit.GalaxyInit();

            SizeOfGalaxy = 1;
            for (int i = 0; i < SizeOfGalaxy * 5; i++)
            {
                using var context = new MyDbContext();
                
                context.StarSystems.Add(StarSystemInit.StarSystemInit(GalaxyInit.Galaxy));
                context.SaveChanges();
            }
        }
    }
}