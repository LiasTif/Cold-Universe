using System;
using WorldGenerationDevelop.Models.WorldCreation.Generation;

namespace WorldGenerationDevelop
{
    public class Program
    {
        static void Main(string[] args)
        {
            GalaxyInitialization galaxyInit = new GalaxyInitialization();
            GalaxyAccess galaxyAccess = new GalaxyAccess();
            StarSystemInitialization starSystemInit = new StarSystemInitialization();
            StarSystemAccess starSystemAccess = new StarSystemAccess();

            //Console.WriteLine(galaxyAccess.GetGalaxy(1).Name);
            //Console.WriteLine(starSystemAccess.GetStarSystem(1).Name);

            //galaxyAccess.RemoveGalaxy(1);

            //galaxyInit.GalaxyInit();

            //for (int i = 1; i < 6; i++)
            //{
            //    starSystemInit.ChangeStarSystemParentId(i, 2);
            //}

            Console.ReadKey();
        }
    }
}