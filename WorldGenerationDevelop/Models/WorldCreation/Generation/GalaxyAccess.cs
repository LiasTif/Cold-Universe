namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class GalaxyAccess
    {
        /// <summary>
        /// get information about galaxy
        /// </summary>
        public Galaxy GetGalaxy(int id)
        {
            using var context = new MyDbContext();
            return context.Galaxies.Find(id);
        }

        /// <summary>
        /// remove galaxy from db
        /// </summary>
        public void RemoveGalaxy(int id)
        {
            using var context = new MyDbContext();

            context.Galaxies.Remove(context.Galaxies.Find(id));
            context.SaveChanges();
        }
    }
}
