
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address
        {
            Street = "123 Main St",
            City = "Cityville",
            State = "Stateville",
            Country = "USA"
        };

        Address address2 = new Address
        {
            Street = "456 Elm St",
            City = "Townsville",
            State = "Provincetown",
            Country = "Canada"
        };

        // Create customers
        Customer customer1 = new Customer
        {
            Name = "John Doe",
            Address = address1
        };

        Customer customer2 = new Customer
        {
            Name = "Jane Smith",
            Address = address2
        };

        // Create products
        Product product1 = new Product
        {
            Name = "Product 1",
            ProductId = 1,
            Price = 10.5m,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            ProductId = 2,
            Price = 15.75m,
            Quantity = 3
        };

        // Create orders
        Order order1 = new Order
        {
            Customer = customer1,
            Products = new List<Product> { product1, product2 }
        };

        Order order2 = new Order
        {
            Customer = customer2,
            Products = new List<Product> { product2 }
        };

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalCost());
    }
}