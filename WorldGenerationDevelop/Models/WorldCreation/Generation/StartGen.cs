using WorldGenerationDevelop.Models.WorldCreation.Generation.Galaxies;
using WorldGenerationDevelop.Models.WorldCreation.Generation.Sectors;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StartGen
    {
        public GalaxyInitialization GalaxyInit { get; } = new GalaxyInitialization();
        public SectorInitialization SectorInit { get; } = new SectorInitialization();

        /// <summary>
        /// numerical indicator of the size of the galaxy
        /// </summary>
        public int SizeOfGalaxy { private get; set; }

        /// <summary>
        /// start generation
        /// </summary>
        public void GenerateWorld()
        {
            Galaxy galaxy = GalaxyInit.GalaxyInit();

            SizeOfGalaxy = 1;
            for (int i = 0; i < SizeOfGalaxy * 5; i++)
            {
                using var context = new MyDbContext();

                // generate sectors and add them to DataBase
                context.Sectors.Add(SectorInit.SectorInit(galaxy));
                context.SaveChanges();
            }
        }
    }
}