using System;
using System.Collections.Generic;

public class Order
{
    // Private member variables (encapsulation)
    private List<Product> _products;
    private Customer _customer;

    // Constants for shipping costs
    private const double USA_SHIPPING_COST = 5.0;
    private const double INTERNATIONAL_SHIPPING_COST = 35.0;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate the total price of the order
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        // Sum up the cost of all products
        foreach (Product product in _products)
        {
            totalPrice += product.CalculateTotalCost();
        }

        // Add shipping cost based on customer location
        if (_customer.LivesInUSA())
        {
            totalPrice += USA_SHIPPING_COST;
        }
        else
        {
            totalPrice += INTERNATIONAL_SHIPPING_COST;
        }

        return totalPrice;
    }

    // Generate a packing label
    public string GetPackingLabel()
    {
        string packingLabel = "PACKING LABEL:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    // Generate a shipping label
    public string GetShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL:\n";
        shippingLabel += $"Customer: {_customer.Name}\n";
        shippingLabel += $"Address:\n{_customer.Address.GetFullAddress()}";

        return shippingLabel;
    }

    // Getters and setters
    public List<Product> Products
    {
        get { return _products; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }
}