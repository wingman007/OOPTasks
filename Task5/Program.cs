namespace Task5
{
    class Program
    {
        static void Main()
        {
            Product product1 = new();
            Console.WriteLine(product1);
            Product product2 = new("Product 1", 12345.67m, "Vendor 1");
            Console.WriteLine(product2);
            Product product3 = new(2432.543m, "Product 2", "Vendor 2");
            Console.WriteLine(product3);

            Product.Warehouse = "Warehouse 2";

            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);

            Console.WriteLine(Product.InstancesCounter);
        }
    }
}
