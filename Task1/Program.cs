namespace Task1
{
    class Program
    {
        static void Main()
        {
            House house1 = new House();
            Console.WriteLine(house1);
            House house2 = new House(64.5, 1, 1);
            Console.WriteLine(house2);
            House house3 = new House(1, 75.4, 2);
            Console.WriteLine(house3);

            House.Country = "Germany";

            Console.WriteLine(house1);
            Console.WriteLine(house2);
            Console.WriteLine(house3);

            Console.WriteLine(House.InstancesCounter);
        }
    }
} 
