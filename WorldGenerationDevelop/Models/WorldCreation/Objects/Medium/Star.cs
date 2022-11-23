#nullable enable
using System.Collections.Generic;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Star : IBase
    {
        #region Base
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        #endregion

        #region Parent
        public int StarSystemId { get; set; }
        public virtual StarSystem? StarSystem { get; set; }
        #endregion

        #region Child objects
        public virtual ICollection<Planet>? PlanetsId { get; set; }
        public virtual ICollection<AsteroidField>? AsteroidFieldsId { get; set; }
        public virtual ICollection<Station>? StationsId { get; set; }
        public virtual ICollection<Fleet>? FleetsId { get; set; }
        #endregion

        public char? StarType { get; set; }
    }
}
