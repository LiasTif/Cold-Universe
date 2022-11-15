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
            return new Sector
            {
                Name = NameGen.GenerateName(),
                Galaxy = parentGalaxy,
                GalaxyId = parentGalaxy.Id
            };
        }
    }
}
