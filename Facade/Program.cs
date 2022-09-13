namespace Facade;

class Program
{
    static void Main(String[] args)
    {
        Order order = new Order();
        order.PlaceOrder();
        Console.Read();
    }
}

