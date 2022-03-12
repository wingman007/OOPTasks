namespace Task10
{
    class Program
    {
        static void Main()
        {
            IMakeNoise cat = new Cat("Flufy", 3);
            IMakeNoise dog = new Dog("Rex", 2);

            AnimalTrainer trainer = new AnimalTrainer(cat);
            Console.WriteLine(trainer.TrainAnimal());

            trainer.Entity = dog;
            Console.WriteLine(trainer.TrainAnimal());

            trainer.Entity = null;
            Console.WriteLine(trainer.TrainAnimal());
        }
    }
}