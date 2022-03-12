namespace Task3
{
    internal class Planet
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double DistanceFromStar { get; set; }
        public static int InstancesCounter { get; private set; }
        public static string CommonStar { get; set; }

        static Planet()
        {
            CommonStar = "Sun";
        }
        public Planet()
            : this("Default", 0, 0)
        {

        }
        public Planet(string name, double mass, double distanceFromStar)
        {
            Name = name;
            Mass = mass;
            DistanceFromStar = distanceFromStar;
            InstancesCounter++;
        }
        public Planet(double distanceFromStar, string name, double mass)
            : this(name, mass, distanceFromStar)
        {

        }

        public override string ToString()
        {
            return String.Format(
                $"Name = {Name}, Mass = {Mass}, DistanceFromStar = {DistanceFromStar}, CommonStar = {CommonStar}");
        }
    }
}
