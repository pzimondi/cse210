using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Address address2 = new Address("12 Maple Avenue", "Vancouver", "BC", "Canada");

        // Create Customers
        Customer customer1 = new Customer("Homer Simpson", address1);
        Customer customer2 = new Customer("Emily Chen", address2);

        // Create Products
        Product product1 = new Product("Duff Beer Pack", "DB100", 15.99, 3);
        Product product2 = new Product("Donut Box", "DN200", 5.50, 12);
        Product product3 = new Product("Wireless Headphones", "WH300", 120.00, 1);
        Product product4 = new Product("Coffee Mug", "CM400", 12.75, 2);
        Product product5 = new Product("Notebook Set", "NB500", 22.50, 5);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Orders
        Console.WriteLine("========== Order 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}\n");

        Console.WriteLine("========== Order 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
    }
}
