class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order()
    {
        Products = new List<Product>();
    }

    public decimal CalculateTotalCost()
    {
        decimal totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.CalculateTotalPrice();
        }

        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in Products)
        {
            packingLabel += $"Product: {product.Name}\nID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Name: {Customer.Name}\nAddress:\n{Customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}