namespace WorldGenerationDevelop.Models.WorldCreation.Generation.Galaxies
{
    public class GalaxyAccess
    {
        /// <summary>
        /// get Galaxy by id
        /// </summary>
        public Galaxy GetGalaxy(int id)
        {
            using var context = new MyDbContext();
            return context.Galaxies.Find(id);
        }

        /// <summary>
        /// remove galaxy from DataBase by id
        /// </summary>
        public void RemoveGalaxy(int id)
        {
            using var context = new MyDbContext();

            context.Galaxies.Remove(context.Galaxies.Find(id));
            context.SaveChanges();
        }
    }
}
