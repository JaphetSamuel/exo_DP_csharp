using System;

namespace Factory
{
    class Program
    {
        static void Main(String[] args)
        {
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");
            
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}

