// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Console.WriteLine("Hello, World!");

IPrice item1 = new Item() { 
    Name = "Item1",
    Price = 10
};
IPrice item2 = new ComplexItem()
{
    ComplexItems = new List<Item>() {
        new Item() {
            Name = "Item2",
            Price = 11
        },
        new ExpirationItem() {
            Name = "Item2",
            Price = 11,
            ExpirationDate = DateTime.Now
        }

    }
};

OrderItem orderItem1 = new OrderItem();
orderItem1.Items.Add(item1);

OrderItem orderItem2 = new OrderItem();
orderItem2.Items.Add(item2);

Order order = new Order();
order.Orders.Add(orderItem1);
order.Orders.Add(orderItem2);

Console.WriteLine(order.getTotalprice());