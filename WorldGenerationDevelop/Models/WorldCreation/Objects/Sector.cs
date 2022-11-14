using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Sector : IBase
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parent
        public int GalaxyId { get; set; }
        public virtual Galaxy Galaxy { get; set; }
        #endregion
    }
}