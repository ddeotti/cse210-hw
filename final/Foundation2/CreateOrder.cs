public class CreateOrder
{
    public CreateOrder()
    {

    }

    public void Create()
    {

        Product product1 = new Product("Laptop", "LPT123", 1200.50m, 1);
        Product product2 = new Product("Mouse", "MSE456", 25.99m, 2);
        Product product3 = new Product("Keyboard", "KYB789", 45.99m, 1);

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Othertown", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order #1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Order #1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Order #1 Total Cost: ${order1.TotalCost()}");

        Console.WriteLine("\nOrder #2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Order #2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Order #2 Total Cost: ${order2.TotalCost()}");
    }
   
}

