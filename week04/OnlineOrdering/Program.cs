using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop Pro", "LP15", 1200.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM-01", 25.50, 2));
        order1.AddProduct(new Product("USB-C Hub", "UCH-05", 45.00, 1));

        
        
        
        Address address2 = new Address("456 Oak Avenue", "Vancouver", "BC", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Gaming Keyboard", "GK-RGB", 150.75, 1));
        order2.AddProduct(new Product("4K Monitor", "M27-4K", 399.99, 1));


        Console.WriteLine("--- Details ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($" Total: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine("\n========================================\n");

        Console.WriteLine("--- Detais order 2 ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order2.CalculateTotalCost():F2}");
    }
}