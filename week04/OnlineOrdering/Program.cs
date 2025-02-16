using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");

        Address address1 = new Address("Batcave blvd", "Gotham", "NY", "USA");
        Customer customer1 = new Customer("Bruce Wayne",address1);

        Address address2 = new Address("Piccadilly Circus", "London", "LON", "UK");
        Customer customer2 = new Customer("Elton John",address2);

        Product hero1 = new Product("Rubber bat",614,0.75,1000);
        Product hero2 = new Product("Kevlar plate",08163,29.43,43);
        Product hero3 = new Product("Tactical cleaner",3831734,3.75,12);
        Product hero4 = new Product("Party glasses",58122,1.15,120);
        Product music1 = new Product("Yamaha Piano",1948,10000,1); 
        Product music2 = new Product("Sparkles",291469,0.3,50);
        Product music3 = new Product("Rocket man action figure",64732,25.54,7);

        Order order1 = new Order(customer1);
        order1.AddProduct(hero1);
        order1.AddProduct(hero2);
        order1.AddProduct(hero3);
        order1.AddProduct(hero4);

        Order order2 = new Order(customer2);
        order2.AddProduct(music1);
        order2.AddProduct(music2);
        order2.AddProduct(music3);

        Console.Clear();

        Console.WriteLine("ORDER #1 __________________________");
        Console.WriteLine(order1.PackagingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total price: ${order1.TotalPrice()}\n");

        Console.WriteLine("ORDER #2 __________________________");
        Console.WriteLine(order2.PackagingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total price: ${order2.TotalPrice()}");


    }
}