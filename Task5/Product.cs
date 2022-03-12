namespace Task5
{
    internal class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Vendor { get; set; }
        public static int InstancesCounter { get; private set; }
        public static string Warehouse { get; set; }

        static Product()
        {
            Warehouse = "Warehouse 1";
        }
        public Product()
            : this("Default", 0.0m, "Default")
        {

        }
        public Product(string name, decimal price, string vendor)
        {
            Name = name;
            Price = price;
            Vendor = vendor;
            InstancesCounter++;
        }
        public Product(decimal price, string name,  string vendor)
            : this(name, price, vendor)
        {

        }

        public override string ToString()
        {
            return String.Format(
                $"Name = {Name}, Price = {Price}, Vendor = {Vendor}, Warehouse = {Warehouse}");
        }
    }
        
}
