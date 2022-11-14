using System;
using WorldGenerationDevelop.Models;

namespace WorldGenerationDevelop
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(galaxyAccess.GetGalaxy(1).Name);
            //Console.WriteLine(starSystemAccess.GetStarSystem(1).Name);

            //galaxyAccess.RemoveGalaxy(1);

            //galaxyInit.GalaxyInit();

            //for (int i = 1; i < 6; i++)
            //{
            //    starSystemInit.ChangeStarSystemParent(i, 2);
            //}

            //context.Galaxies.RemoveRange(context.Galaxies);
            //context.SaveChanges();

            //context.StarSystems.RemoveRange(context.StarSystems);
            //context.SaveChanges();

            using var context = new MyDbContext();

            Console.WriteLine("Opertation has ended");
            Console.ReadKey();
        }
    }
}