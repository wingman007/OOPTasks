namespace Task9
{
    class Program
    {
        static void Main()
        {
            IIntroduce sportCar = new SportCar("BMV", 2019, 200);
            IIntroduce truck = new Truck("Mercedes", 2018, 100);

            Manager manager = new Manager(sportCar);
            Console.WriteLine(manager.GetVehicleInfo());

            manager.Entity = truck;
            Console.WriteLine(manager.GetVehicleInfo());

            manager.Entity = null;
            Console.WriteLine(manager.GetVehicleInfo());
        }
    }
}