class Order
{
    private List<Product> products;
    private Customer customer;

    public Order()
    {
        products = new List<Product>();
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public decimal CalculateTotalCost()
    {
        decimal totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.CalculateTotalPrice();
        }

        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.Name}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Name: {customer.Name}\nAddress:\n{customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}