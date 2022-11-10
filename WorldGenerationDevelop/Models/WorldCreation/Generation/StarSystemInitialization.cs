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

        /// <summary>
        /// change the ParrentId in star system
        /// </summary>
        /// <param name="id">star system id</param>
        /// <param name="newParrentId">new parrent id</param>
        public void ChangeStarSystemParentId(int id, int newParrentId)
        {
            using var context = new MyDbContext();

            context.StarSystems.Find(id).ParentId = newParrentId;
            context.SaveChanges();
        }
    }
}
