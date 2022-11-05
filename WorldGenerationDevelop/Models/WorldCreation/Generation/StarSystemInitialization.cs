﻿namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StarSystemInitialization
    {
        public NameGenerator NameGen { get; } = new NameGenerator();
        /// <summary>
        /// current star system
        /// </summary>
        public StarSystem StarSystem { get; private set; } = new StarSystem();


        /// <summary>
        /// generate star system
        /// </summary>
        /// <param name="parentGalaxy">parent galaxy object</param>
        public StarSystem StarSystemInit(Galaxy parentGalaxy)
        {
            return new StarSystem
            {
                ParentId = parentGalaxy.Id,
                Name = NameGen.GenerateName()
            };
        }
    }
}