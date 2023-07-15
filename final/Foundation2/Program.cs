
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            Street = "123 Main St",
            City = "Cityville",
            State = "Stateville",
            Country = "USA"
        };

        Customer customer = new Customer
        {
            Name = "John Doe",
            Address = address
        };

        Product product1 = new Product
        {
            Name = "sneaker",
            Price = 10.5m,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Bag",
            Price = 15.75m,
            Quantity = 3
        };

        Order order = new Order
        {
            Customer = customer,
            Products = new List<Product> { product1, product2 }
        };

        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order.CalculateTotalCost());
    }
}







