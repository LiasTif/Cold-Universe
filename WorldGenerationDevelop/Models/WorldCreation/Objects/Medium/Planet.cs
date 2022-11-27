using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Planet : IBase, ITemperature, IPlanetType, IAtmosphereType
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parents
        public int StarId { get; set; }
        public virtual Star Star { get; set; }
        public int StarSystemId { get; set; }
        public virtual StarSystem StarSystem { get; set; }
        #endregion

        #region Child objects
        [ForeignKey("Id")]
        public virtual ICollection<Satellite> Satellites { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Asteroid> Asteroids { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Station> Stations { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Fleet> Fleets { get; set; }
        #endregion

        public string Temperature { get; set; }
        public string PlanetType { get; set; }
        public string Mass { get; set; }
        public bool AtmosphereType { get; set; }
    }
}