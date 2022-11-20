namespace WorldGenerationDevelop.Models.WorldCreation.Generation.StarSystems
{
    public class StarSystemInitialization
    {
        private NameGenerator NameGen { get; } = new NameGenerator();

        /// <summary>
        /// generate star system
        /// </summary>
        /// <param name="parentGalaxy">parent galaxy object</param>
        public StarSystem StarSystemInit(Sector parentSector)
        {
            return new StarSystem
            {
                Sector = parentSector,
                Name = NameGen.GenerateName()
            };
        }
    }
}