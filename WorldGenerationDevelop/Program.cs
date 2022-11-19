using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using WorldGenerationDevelop.Models;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelop
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartGen startGen = new StartGen();
            using var context = new MyDbContext();

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

            //var descriptions = new List<Description>
            //{
            //    new Description { Id = 1, ObjectType = "Galaxy", Text = "  Гравитационно-связанная система из звёзд, звёздных скоплений, межзвёздного газа и пыли, тёмной материи, планет.\n  Все объекты в составе галактики участвуют в движении относительно общего центра масс." },
            //    new Description { Id = 2, ObjectType = "Sector", Text = "  Скопление нескольких звездных систем. Сектора существуют условно, для удобства каталогизирования и навигации." },
            //    new Description { Id = 3, ObjectType = "StarSystem", Text = "  Гравитационно-связанная система из нескольких звёзд с замкнутыми орбитами." },
            //    new Description { Id = 4, ObjectType = "Star", Text = "  Массивное самосветящееся небесное тело, состоящее из газа и плазмы." }
            //};

            //context.Descriptions.AddRange(descriptions);

            //startGen.GenerateWorld();

            //var galaxyDescription = context.Descriptions
            //        .Where(g => g.ObjectType == "Galaxy")
            //        .SingleOrDefault();

            //var galaxyDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Galaxy");

            //context.Galaxies.Find(14).Description = galaxyDescription.Text;

            context.SaveChanges();

            //context.Galaxies.RemoveRange(context.Galaxies);
            //context.Sectors.RemoveRange(context.Sectors);

            //context.SaveChanges();

            //startGen.GenerateWorld();

            Console.WriteLine("Opertation has ended");
            Console.ReadKey();
        }
    }
}