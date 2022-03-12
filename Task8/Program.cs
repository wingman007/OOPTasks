namespace Task8
{
    class Program
    {
        static void Main()
        {
            IIntorducable elephant = new Elephant("Jumbo", 15, 2000);
            IIntorducable giraffe = new Giraffe("Pepe", 10, 245);
            
            Manager manager = new Manager(elephant);
            Console.WriteLine(manager.GetAnimalInfo());
            
            manager.Entity = giraffe;
            Console.WriteLine(manager.GetAnimalInfo());
            
            manager.Entity = null;
            Console.WriteLine(manager.GetAnimalInfo());
        }
    }
}