using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- Order 1 -----\n");

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("João Silva", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P001", 1200.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.00, 2);
        Product product3 = new Product("Teclado", "P003", 75.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine("----- Order 2 -----\n");

        Address address2 = new Address("Rua das Flores 456", "São Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Maria Santos", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Monitor", "P004", 300.00, 2);
        Product product5 = new Product("Webcam", "P005", 80.00, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal: ${order2.CalculateTotalCost():F2}");
    }
}