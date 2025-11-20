using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 - USA customer
        Address addr1 = new Address("Fifth Avenue", "New York", "New York", "USA"); // Address instance
        Customer cust1 = new Customer("David Washington", addr1);    // Customer object
        Order order1 = new Order(cust1);                            // Order object

        order1.AddProduct(new Product("Laptop", "L100", 850, 1)); // Adding Products to the Order Object
        order1.AddProduct(new Product("Mouse", "M200", 20, 2));

        // ORDER 2 - International customer
        Address addr2 = new Address("William Street", "Central", "Kampala", "Uganda");
        Customer cust2 = new Customer("Marvel Arafat", addr2);
        Order order2 = new Order(cust2);                   // new order object for someone who is not in USA

        order2.AddProduct(new Product("Phone", "P500", 600, 1));
        order2.AddProduct(new Product("Earbuds", "E150", 50, 1));
        order2.AddProduct(new Product("Charger", "C330", 25, 1));

        // Displaying everything
        Console.WriteLine("\n===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order1.GetTotalPrice()}\n");

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order2.GetTotalPrice()}\n");
    }
}
