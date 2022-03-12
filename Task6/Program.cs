namespace Task6
{
    class Program
    {
        static void Main()
        {
            var surfaceCalculator = new SurfaceCalculator();
            Console.WriteLine(surfaceCalculator.getInfo());
            Console.WriteLine(surfaceCalculator.getSurface());

            var paralelepiped = new Parallelepiped(5.4, 5.6, 7.8);
            surfaceCalculator.GeometricShape = paralelepiped;
            Console.WriteLine(surfaceCalculator.getInfo());
            Console.WriteLine(surfaceCalculator.getSurface());

            var sphere = new Sphere(6.7);
            surfaceCalculator.GeometricShape = sphere;
            Console.WriteLine(surfaceCalculator.getInfo());
            Console.WriteLine(surfaceCalculator.getSurface());
        }
    }
}
