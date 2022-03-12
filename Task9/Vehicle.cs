namespace Task9
{
    enum VehicleType
    {
        SportCar,
        Truck
    }
    internal abstract class Vehicle : IIntroduce
    {
        public VehicleType Type { get; set; }
        public string Brand { get; set; }
        public int YearОfМanufacture { get; set; }

        public Vehicle(VehicleType type, string brand, int yearОfМanufacture)
        {
            Type = type;
            Brand = brand;
            YearОfМanufacture = yearОfМanufacture;
        }
        public virtual string Introduce()
        {
            return $"Type of the vehicle = {Type}, Brand = {Brand}, YearOfManufacutr = {YearОfМanufacture}";
        }
    }
}
