namespace Task2
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car();
            Console.WriteLine(car1);
            Car car2 = new Car(150, 101, "Toyota");
            Console.WriteLine(car2);
            Car car3 = new Car("Honda", 250, 130);
            Console.WriteLine(car3);

            Car.Color = "Blue";

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);

            Console.WriteLine(Car.InstancesCounter);
        }
    }
}
