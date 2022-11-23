using System.Linq;

namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Stations
{
    /// <summary>
    /// initialize the station
    /// </summary>
    public class StationInitialization
    {
        #region properties
        private NameGenerator NameGen { get; } = new NameGenerator();
        private StationSizeGenerator SizeGen { get; } = new StationSizeGenerator();
        private StationTypeGenerator TypeGen { get; } = new StationTypeGenerator();
        #endregion

        /// <summary>
        /// generate station
        /// </summary>
        /// <param name="parentStar">Star, parrent object</param>
        /// <returns>initialized station</returns>
        public Station StationInit(Star parentStar)
        {
            using var context = new DbContext();
            var StationDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Station");

            return new Station
            {
                Name = NameGen.GenerateName(),
                Description = StationDescription.Text,
                Size = SizeGen.SizeGen(),
                StationType = TypeGen.TypeGen(),
                Star = parentStar,
                StarId = parentStar.Id
            };
        }

        /// <summary>
        /// generate station
        /// </summary>
        /// <param name="parentPlanet">Planet, parrent object</param>
        /// <returns>initialized station</returns>
        public Station StationInit(Planet parentPlanet)
        {
            using var context = new DbContext();
            var StationDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Station");

            return new Station
            {
                Name = NameGen.GenerateName(),
                Description = StationDescription.Text,
                Size = SizeGen.SizeGen(),
                StationType = TypeGen.TypeGen(),
                Planet = parentPlanet,
                PlanetId = parentPlanet.Id
            };
        }

        /// <summary>
        /// generate station
        /// </summary>
        /// <param name="parentSatellite">Satellite, parrent object</param>
        /// <returns>initialized station</returns>
        public Station StationInit(Satellite parentSatellite)
        {
            using var context = new DbContext();
            var StationDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Station");

            return new Station
            {
                Name = NameGen.GenerateName(),
                Description = StationDescription.Text,
                Size = SizeGen.SizeGen(),
                StationType = TypeGen.TypeGen(),
                Satellite = parentSatellite,
                SatelliteId = parentSatellite.Id
            };
        }
    }
}
