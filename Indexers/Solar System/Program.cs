using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System
{
    class SolarSystem
    {
        string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune", "Pluto" };
        private int GetPlanet(string testPlanet)
        {
            for (int j = 0; j < planets.Length; j++)
            {
                if (planets[j] == testPlanet)
                {
                    return j;
                }
            }
            throw new ArgumentOutOfRangeException
                (testPlanet, "test must be ");
        }
        public int this[string planet]
        {
            get
            {
                return GetPlanet(planet);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem plan = new SolarSystem();
            Console.WriteLine(plan["Mars"]);

            //Console.WriteLine(plan["Marsss"]);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
