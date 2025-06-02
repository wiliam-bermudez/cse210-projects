using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
         // Create products
        Product product1 = new Product("Laptop", 101, 500.00, 1);
        Product product2 = new Product("Mouse", 102, 25.00, 2);
        Product product3 = new Product("Keyboard", 103, 50.00, 1);

        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display packing and shipping labels, and total price
        foreach (var order in new List<Order> { order1, order2 })
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("\nShipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"\nTotal Price: ${order.TotalPrice()}\n");
        }
    }


   
      
}