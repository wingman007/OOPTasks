namespace Task7
{
    class Program
    {
        static void Main()
        {
            var volumeCalculator = new VolumeCalculator();
            Console.WriteLine(volumeCalculator.getInfo());
            Console.WriteLine(volumeCalculator.getVolume());

            var cone = new Cone(5.4, 5.6);
            volumeCalculator.GeometricShape = cone;
            Console.WriteLine(volumeCalculator.getInfo());
            Console.WriteLine(volumeCalculator.getVolume());

            var cylinder = new Cylinder(3.5, 6.7);
            volumeCalculator.GeometricShape = cylinder;
            Console.WriteLine(volumeCalculator.getInfo());
            Console.WriteLine(volumeCalculator.getVolume());
        }
    }
}
