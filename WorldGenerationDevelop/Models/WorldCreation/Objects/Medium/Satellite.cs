using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Satellite : IBase, IPlanetType, ITemperature, IAtmosphereType
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parent
        public int PlanetId { get; set; }
        public virtual Planet Planet { get; set; }
        #endregion

        #region Child objects
        [ForeignKey("Id")]
        public virtual ICollection<Asteroid> Asteroids { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Station> Stations { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Fleet> Fleets { get; set; }
        #endregion

        public string PlanetType { get; set; }
        public string Temperature { get; set; }
        public bool AtmosphereType { get; set; }
    }
}
