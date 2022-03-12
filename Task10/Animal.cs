namespace Task10
{
    internal abstract class Animal : IMakeNoise
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual string MakeNoise()
        {
            return $"Hello! My name is {Name} and I am {Age} years old.";
        }
    }
}
