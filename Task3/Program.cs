namespace Task3
{
    class Program
    {
        static void Main()
        {
            Planet planet1 = new Planet();
            Console.WriteLine(planet1);
            Planet planet2 = new Planet("Mercury", 12345.67, 423423.56);
            Console.WriteLine(planet2);
            Planet planet3 = new Planet(250432.543, "Mars", 3421423.543);
            Console.WriteLine(planet3);

            Planet.CommonStar = "Antares";

            Console.WriteLine(planet1);
            Console.WriteLine(planet2);
            Console.WriteLine(planet3);

            Console.WriteLine(Planet.InstancesCounter);
        }
    }
}
