namespace Task8
{
    internal class Giraffe : Animal
    {
        public double NeckLength { get; set; }
        public Giraffe(string name, int age, double neckLenght) : base(name, age)
        {
            NeckLength = neckLenght;
        }

        public override string IntroduceYourself()
        {
            return base.IntroduceYourself() + $" I am a Giraffe. The Length of my Neck is {NeckLength}";
        }
    }
}
