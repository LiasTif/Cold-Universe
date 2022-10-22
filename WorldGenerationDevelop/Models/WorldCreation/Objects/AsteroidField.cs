﻿using WorldGenerationDevelop.Interfaces.WorldCreation;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class AsteroidField : BaseObject, IParentId, ISize
    {
        public int ParentId { get; set; }
        public byte Size { get; set; }
    }
}