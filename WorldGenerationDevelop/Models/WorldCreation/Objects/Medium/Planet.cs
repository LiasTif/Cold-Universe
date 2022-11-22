#nullable enable
using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Planet : IBase, ITemperature, IPlanetType, IAtmosphereType
    {
        #region Base
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        #endregion

        public string? Temperature { get; set; }
        public string? PlanetType { get; set; }
        public string? Mass { get; set; }
        public bool? AtmosphereType { get; set; }
    }
}