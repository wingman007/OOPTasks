namespace Task2
{
    internal class Car
    {
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public string Manufacturer { get; set; }
        public static int InstancesCounter { get; private set; }
        public static string Color { get; set; }

        static Car()
        {
            Color = "White";
        }
        public Car()
            : this(0, 0, "Default")
        {

        }
        public Car(int maxSpeed, int horsePower, string manufacturer)
        {
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            Manufacturer = manufacturer;
            InstancesCounter++;
        }
        public Car(string manufacturer, int maxSpeed, int horsePower)
            : this(maxSpeed, horsePower, manufacturer)
        {

        }

        public override string ToString()
        {
            return String.Format(
                $"MaxSpeed = {MaxSpeed}, HorsePower = {HorsePower}, Manufacturer = {Manufacturer}, Color = {Color}");
        }
    }
}
