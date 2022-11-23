#nullable enable
using System.Collections.Generic;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Planet : IBase, ITemperature, IPlanetType, IAtmosphereType
    {
        #region Base
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        #endregion

        #region Parents
        public int StarId { get; set; }
        public virtual Star? Star { get; set; }
        public int StarSystemId { get; set; }
        public virtual StarSystem? StarSystem { get; set; }
        #endregion

        #region Child objects
        public virtual ICollection<Satellite>? SatellitesId { get; set; }
        public virtual ICollection<Asteroid>? AsteroidsId { get; set; }
        public virtual ICollection<Station>? StationsId { get; set; }
        public virtual ICollection<Fleet>? FleetsId { get; set; }
        #endregion

        public string? Temperature { get; set; }
        public string? PlanetType { get; set; }
        public string? Mass { get; set; }
        public bool? AtmosphereType { get; set; }
    }
}