using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Apple", 1, 25, 3);
        Product product2 = new Product("Orange", 2, 15, 1);
        Product product3 = new Product("Milk", 3, 30, 5);

        Address address1 = new Address("700S 200W", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("42 W Main St", "Toronto", "Ontario", "Canada");

        Customer customer1 = new Customer("USA Customer", address1);
        Customer customer2 = new Customer("Canada Customer", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        DisplayOrderInformation(order1);
        Console.WriteLine();
        DisplayOrderInformation(order2);
    }

    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine($"Order Information for Customer: {order.Customer.Name}");
        Console.WriteLine($"{order.GetPackingLabel()}");
        Console.WriteLine($"{order.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}\n");
    }
}