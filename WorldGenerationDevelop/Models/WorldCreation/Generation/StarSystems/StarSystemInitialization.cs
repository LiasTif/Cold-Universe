//namespace WorldGenerationDevelop.Models.WorldCreation.Generation.StarSystems
//{
//    public class StarSystemInitialization
//    {
//        public NameGenerator NameGen { get; } = new NameGenerator();
//        /// <summary>
//        /// current star system
//        /// </summary>
//        public StarSystem StarSystem { get; private set; } = new StarSystem();


//        /// <summary>
//        /// generate star system
//        /// </summary>
//        /// <param name="parentGalaxy">parent galaxy object</param>
//        public StarSystem StarSystemInit(Galaxy parentGalaxy)
//        {
//            return new StarSystem
//            {
//                Galaxy = parentGalaxy,
//                Name = NameGen.GenerateName()
//            };
//        }

//        /// <summary>
//        /// change the ParrentId in star system
//        /// </summary>
//        /// <param name="id">star system id</param>
//        /// <param name="newParrentId">new parrent id</param>
//        public void ChangeStarSystemParent(int id, Galaxy newParentGalaxy)
//        {
//            using var context = new MyDbContext();

//            context.StarSystems.Find(id).Galaxy = newParentGalaxy;
//            context.SaveChanges();
//        }
//    }
//}
