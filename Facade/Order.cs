using Facade.librairie;

namespace Facade;

public class Order
{
    public void PlaceOrder()
    {
        Console.WriteLine("Begin to place order");
        Product product = new Product();
        product.GetProductDetails();
        Payment payment = new Payment();
        payment.MakePayment();
        Invoice invoice = new Invoice();
        invoice.SendInvoice();
        
        Console.WriteLine("End action");
    }
}