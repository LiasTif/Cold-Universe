using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class StarSystem : IBase
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parent
        public int SectorId { get; set; }
        public virtual Sector Sector { get; set; }
        #endregion

        #region Child objects
        [ForeignKey("Id")]
        public virtual ICollection<Star> Stars { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Planet> Planets { get; set; }
        #endregion
    }
}