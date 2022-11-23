#nullable enable
using System.Collections.Generic;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class StarSystem : IBase
    {
        #region Base
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        #endregion

        #region Parent
        public int? SectorId { get; set; }
        public virtual Sector? Sector { get; set; }
        #endregion

        #region Child objects
        public virtual ICollection<Star>? StarsId { get; set; }
        public virtual ICollection<Planet>? PlanetsId { get; set; }
        #endregion
    }
}