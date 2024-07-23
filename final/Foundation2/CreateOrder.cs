/*

*/
public class CreateOrder
{
    public CreateOrder()
    {

    }

    public void Create()
    {

        Product product1 = new Product("Samsung Television", "STV123", 1200.50, 1);
        Product product2 = new Product("Universal Remote", "MSE456", 25.99, 2);
        Product product3 = new Product("Keyboard", "KYB789", 45.99, 1); 

        Address address1 = new Address("7817 Some St.Middletown", "New York ", "NY", "USA");
        Address address2 = new Address("123 Avenida Brasil", "Campinas", "SP", "Brasil");

        Customer customer1 = new Customer("John Peter Paul", address1);
        Customer customer2 = new Customer("Jose Pedro Paulo", address2);

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

