using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WorldGenerationDevelop.Models;

namespace WorldGenerationDevelop
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var context = new MyDbContext();

            //var galaxyDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Galaxy");
            //var sectorDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "Sector");
            //var starSystemDescription = context.Descriptions.SingleOrDefault(c => c.ObjectType == "StarSystem");

            //foreach (StarSystem starSystem in context.StarSystems)
            //{
            //    starSystem.Description = starSystemDescription.Text;
            //}

            context.SaveChanges();

            Console.WriteLine("Opertation has ended");
            Console.ReadKey();
        }
    }
}