namespace WorldGenerationDevelop.Models.WorldCreation.Objects
{
    public abstract class ParrentForSmallObjects
    {
        public abstract int? StarId { get; set; }
        public abstract Star Star { get; set; }

        public abstract int? PlanetId { get; set; }
        public abstract Planet Planet { get; set; }

        public abstract int? SatelliteId { get; set; }
        public abstract Satellite Satellite { get; set; }
    }
}
