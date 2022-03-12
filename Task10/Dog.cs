namespace Task10
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise()
        {
            return "Bau. I am a dog! " + base.MakeNoise();
        }
    }
}
