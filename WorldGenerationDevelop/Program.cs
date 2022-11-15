using System;
using WorldGenerationDevelop.Models;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelop
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartGen startGen = new StartGen();

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

            context.Galaxies.RemoveRange(context.Galaxies);
            context.Sectors.RemoveRange(context.Sectors);

            context.SaveChanges();

            //startGen.GenerateWorld();

            Console.WriteLine("Opertation has ended");
            Console.ReadKey();
        }
    }
}