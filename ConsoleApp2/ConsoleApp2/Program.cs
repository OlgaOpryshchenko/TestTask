// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");

Order order = new Order();
order.OrderItems = new List<OrderItem>();

order.OrderItems.Add(new OrderItem()
{
    Items = new List<Item>() {
    new Item() {
    Price = 10,
    Name = "test1",
    ExpirationDate = DateTime.Now
    }
    }

});
order.OrderItems.Add(new OrderItem()
{
    Items = new List<Item> () { 
    new Item() {
    Price = 11,
    Name = "test2",
    ExpirationDate = DateTime.Now },

    new Item() {
    Price = 12,
    Name = "test3",
    ExpirationDate = DateTime.Now }
    }
});

Console.WriteLine(order.getTotalPrice());