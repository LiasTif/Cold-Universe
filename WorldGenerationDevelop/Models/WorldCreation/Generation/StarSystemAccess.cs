namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StarSystemAccess
    {
        /// <summary>
        /// get information about star system
        /// </summary>
        public StarSystem GetStarSystem(int id)
        {
            using var context = new MyDbContext();
            return context.StarSystems.Find(id);
        }
    }
}
