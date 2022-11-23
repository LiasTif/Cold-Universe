using System;
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

            //context.Descriptions.Remove(context.Descriptions.Find(5));
            //Description planetDescrtiption = new Description { ObjectType = "Planet", Text = "  Небесное тело, вращающееся вокруг звезды и получающее от него свет и тепло." };

            //context.Descriptions.Add(planetDescrtiption);

            Console.WriteLine("Opertation has ended");
            Console.ReadKey();
        }
    }
}