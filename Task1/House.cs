namespace Task1
{
    internal class House
    {
        public double Size { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfFloors { get; set; }
        public static int InstancesCounter { get; private set; }
        public static string Country { get; set; }

        static House()
        {
            Country = "Bulgaria";
        }
        public House()
            : this(0.0, 0, 0)
        {

        }
        public House(double size, int numberOfBedrooms, int numberOfFloors)
        {
            Size = size;
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfFloors = numberOfFloors;
            InstancesCounter++;
        }
        public House(int numberOfBedrooms, double size,  int numberOfFloors)
            :this(size, numberOfBedrooms, numberOfFloors)
        {

        }

        public override string ToString()
        {
            return String.Format(
                $"Size = {Size}, NumberOfBedrooms = {NumberOfBedrooms}, NumberOfFloors = {NumberOfFloors}, Country = {Country}");
        }
    }
}
