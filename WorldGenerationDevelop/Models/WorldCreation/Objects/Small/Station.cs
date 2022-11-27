﻿using WorldGenerationDevelop.Interfaces.WorldCreation;
using WorldGenerationDevelop.Models.WorldCreation.Objects;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class Station : ParrentForSmallObjects, IBase, ISize
    {
        #region Base
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Parent
        public override int StarId { get; set; }
        public override Star Star { get; set; }
        public override int PlanetId { get; set; }
        public override Planet Planet { get; set; }
        public override int SatelliteId { get; set; }
        public override Satellite Satellite { get; set; }
        #endregion

        public string StationType { get; set; }
        public byte Size { get; set; }
    }
}