namespace Task10
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise()
        {
            return "Meow. I am a cat! " + base.MakeNoise();
        }
    }
}
