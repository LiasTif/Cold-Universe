using System.Collections.Generic;
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Galaxy : IBase
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Child objects
        public virtual ICollection<Sector> SectorsId { get; set; }
        #endregion
    }
}