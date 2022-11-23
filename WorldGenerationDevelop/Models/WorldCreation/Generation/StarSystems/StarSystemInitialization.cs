using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.StarSystems
{
    /// <summary>
    /// initialize the star system
    /// </summary>
    public class StarSystemInitialization
    {
        #region properties
        private NameGenerator NameGen { get; } = new NameGenerator();
        #endregion

        /// <summary>
        /// generate star system
        /// </summary>
        /// <param name="parentGalaxy">parent galaxy object</param>
        public StarSystem StarSystemInit(Sector parentSector)
        {
            using var context = new DbContext();
            var sectorDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Sector");

            return new StarSystem
            {
                Sector = parentSector,
                SectorId = parentSector.Id,
                Name = NameGen.GenerateName(),
                Description = sectorDescription.Text
            };
        }
    }
}