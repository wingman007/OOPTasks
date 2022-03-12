namespace Task9
{
    internal class SportCar : Vehicle
    {
        public int MaxSpeed { get; set; }
        public SportCar(string brand, int yearОfМanufacture, int maxSpeed) 
            : base(VehicleType.SportCar, brand, yearОfМanufacture)
        {
            MaxSpeed = maxSpeed;
        }

        public override string Introduce()
        {
            return base.Introduce() + " The MaxSpeed is " + MaxSpeed;
        }
    }
}
