#nullable enable
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

        public string? PlanetType { get; set; }
        public string? Temperature { get; set; }
        public bool? AtmosphereType { get; set; }
    }
}
