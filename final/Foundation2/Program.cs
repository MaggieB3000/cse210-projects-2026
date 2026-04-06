using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123 Rando Street", "Skadoodle Town", "Rando State", "Narnia");
        Customer customer1 = new Customer("Bob Joe", address1);
        Product apple = new Product("apple", "93874", 1.00, 3);
        Product banana = new Product("banana", "23457", 0.28, 5);
        Product bread = new Product("bread", "78993", 2.75, 1);
        List<Product> products1 = new List<Product> { apple, banana, bread };
        Order order1 = new Order(products1, customer1);
        orders.Add(order1);

        Address address2 = new Address("859 E 950 S", "Provo", "Utah", "USA");
        Customer customer2 = new Customer("Margaret Binns", address2);
        Product yarn = new Product("yarn", "21093", 4.99, 5);
        Product buttons = new Product("buttons", "83793", 1.25, 2);
        Product stuffing = new Product("stuffing", "47832", 7.99, 1);
        List<Product> products2 = new List<Product> { yarn, buttons, stuffing };
        Order order2 = new Order(products2, customer2);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine($"\n\n{order.PackingLabel()}\n\n{order.ShippingLabel()}\n\nTotal price: ${order.TotalPrice():F2}");
        }
    }
}