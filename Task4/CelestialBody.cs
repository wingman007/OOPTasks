namespace Task4
{
    enum CelestialBodyTypes
    {
        Asteroid,
        Planet,
        Star
    }

    internal class CelestialBody
    {
        public CelestialBodyTypes Type { get; set; }
        public double Mass { get; set; }
        public double Gravity { get; set; }
        public static int InstancesCounter { get; private set; }
        public static string Galaxy { get; set; }

        static CelestialBody()
        {
            Galaxy = "Milki Way";
        }
        public CelestialBody()
            : this(CelestialBodyTypes.Planet, 0.0, 0.0)
        {

        }
        public CelestialBody(CelestialBodyTypes type, double mass, double gravity)
        {
            Type = type;
            Mass = mass;
            Gravity = gravity;
            InstancesCounter++;
        }
        public CelestialBody(double mass, CelestialBodyTypes type, double gravity)
            : this(type, mass, gravity)
        {

        }

        public override string ToString()
        {
            return String.Format(
                $"Type = {Type}, Mass = {Mass}, Gravity = {Gravity}, Galaxy = {Galaxy}");
        }
    }
}
