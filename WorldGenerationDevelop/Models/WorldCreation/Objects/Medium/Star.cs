using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Star : IBase
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parent
        public int StarSystemId { get; set; }
        public virtual StarSystem StarSystem { get; set; }
        #endregion

        #region Child objects
        [ForeignKey("Id")]
        public virtual ICollection<Planet> Planets { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<AsteroidField> AsteroidFields { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Station> Stations { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Fleet> Fleets { get; set; }
        #endregion

        public char StarType { get; set; }
    }
}
