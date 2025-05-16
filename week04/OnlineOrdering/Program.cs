using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System\n");

        // Create Order #1 (USA customer)
        Console.WriteLine("=== ORDER #1 ===");

        // Create USA address and customer
        Address usaAddress = new Address("123 Main Street", "Seattle", "WA", "USA");
        Customer usaCustomer = new Customer("John Smith", usaAddress);

        // Create order with USA customer
        Order order1 = new Order(usaCustomer);

        // Add products to order
        Product product1 = new Product("Laptop", "TECH001", 899.99, 1);
        Product product2 = new Product("Wireless Mouse", "TECH145", 24.99, 2);
        Product product3 = new Product("USB-C Cable", "TECH378", 12.50, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display order information
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalPrice():F2}");

        // Create Order #2 (International customer)
        Console.WriteLine("\n\n=== ORDER #2 ===");

        // Create international address and customer
        Address internationalAddress = new Address("456 Maple Avenue", "Toronto", "Ontario", "Canada");
        Customer internationalCustomer = new Customer("Emma Johnson", internationalAddress);

        // Create order with international customer
        Order order2 = new Order(internationalCustomer);

        // Add products to order
        Product product4 = new Product("Coffee Maker", "HOME056", 79.99, 1);
        Product product5 = new Product("Coffee Beans (1lb)", "FOOD123", 15.99, 2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order information
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalPrice():F2}");
    }
}