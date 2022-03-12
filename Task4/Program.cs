namespace Task4
{
    class Program
    {
        static void Main()
        {
            CelestialBody celestialBody1 = new CelestialBody();
            Console.WriteLine(celestialBody1);
            CelestialBody celestialBody2 = new CelestialBody(CelestialBodyTypes.Planet, 12345.67, 9.81);
            Console.WriteLine(celestialBody2);
            CelestialBody celestialBody3 = new CelestialBody(2432.543, CelestialBodyTypes.Asteroid, 5.4);
            Console.WriteLine(celestialBody3);

            CelestialBody.Galaxy = "Canis Major Dwarf";

            Console.WriteLine(celestialBody1);
            Console.WriteLine(celestialBody2);
            Console.WriteLine(celestialBody3);

            Console.WriteLine(CelestialBody.InstancesCounter);
        }
    }
}
