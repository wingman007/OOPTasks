namespace Task9
{
    internal class Truck : Vehicle
    {
        public double MaxWeight { get; set; }
        public Truck(string brand, int yearОfМanufacture, double maxWeight) 
            : base(VehicleType.Truck, brand, yearОfМanufacture)
        {
            MaxWeight = maxWeight;
        }

        public override string Introduce()
        {
            return base.Introduce() + " The MaxWeight is " + MaxWeight;
        }
    }
}
