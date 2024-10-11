using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Fruit Tree Ln", "Orem", "UT", "USA");
        Address address2 = new Address("778 Rose St", "Rome", "IT", "Italy");

        Customer customer1 = new Customer("Shannon Lee", address1);
        Customer customer2 = new Customer("Tiff Willey", address2);

        Product product1 = new Product("Keyboard", "WLE369", 50.00m, 1);
        Product product2 = new Product("Charger", "AOE367", 20.00m, 3);
        Product product3 = new Product("Ipad", "YUI873", 200.00m, 2);
        Product product4 = new Product("Laptop", "AUU123", 600.00m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}
