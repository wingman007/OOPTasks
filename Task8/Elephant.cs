namespace Task8
{
    internal class Elephant : Animal
    {
        public double Weight { get; set; }
        public Elephant(string name, int age, double weight) : base(name, age)
        {
            Weight = weight;
        }

        public override string IntroduceYourself()
        {
            return base.IntroduceYourself() + $" I am an Elephant and my weight is {Weight}.";
        }
    }
}
