namespace Task8
{
    internal abstract class Animal : IIntorducable
    {
        public string Name { get; set; }
        public int Age { get; set; } = 0;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual string IntroduceYourself()
        {
            return string.Format($"My name is {Name}. I am {Age} years old.");
        }
    }
}
