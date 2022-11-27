using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class AsteroidField : IBase, ISize
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parents
        public int StarId { get; set; }
        public virtual Star Star { get; set; }
        #endregion

        public byte Size { get; set; }
    }
}
