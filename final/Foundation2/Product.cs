using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private decimal price;
    private int quantity;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public decimal CalculateTotalPrice()
    {
        return price * quantity;
    }
}