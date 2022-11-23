#nullable enable
using System.Collections.Generic;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Satellite : IBase, IPlanetType, ITemperature, IAtmosphereType
    {
        #region Base
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        #endregion

        #region Parent
        public int PlanetId { get; set; }
        public virtual Planet? Planet { get; set; }
        #endregion

        #region Child objects
        public virtual ICollection<Asteroid>? AsteroidsId { get; set; }
        public virtual ICollection<Station>? StationsId { get; set; }
        public virtual ICollection<Fleet>? FleetsId { get; set; }
        #endregion

        public string? PlanetType { get; set; }
        public string? Temperature { get; set; }
        public bool? AtmosphereType { get; set; }
    }
}
