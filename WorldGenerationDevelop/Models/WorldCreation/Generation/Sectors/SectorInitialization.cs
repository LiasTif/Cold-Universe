namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Sectors
{
    public class SectorInitialization
    {
        public NameGenerator NameGen { get; } = new NameGenerator();

        /// <summary>
        /// initialize sector
        /// </summary>
        public Sector SectorInit(Galaxy parentGalaxy)
        {
            using var context = new MyDbContext();

            // set parameters for the sector
            Sector sector = new Sector
            {
                Name = NameGen.GenerateName(),
                Galaxy = parentGalaxy,
                GalaxyId = parentGalaxy.Id
            };

            // add sector to DataBase
            context.Sectors.Add(sector);
            context.SaveChanges();

            return sector;
        }
    }
}
