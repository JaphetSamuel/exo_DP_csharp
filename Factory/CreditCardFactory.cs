namespace Factory;

public class CreditCardFactory
{
    

    public static ICreditCard GetCreditCard(string cardType)
    {
        ICreditCard cardDetail = null;
        
        if (cardType == "MoneyBack")
        {
            cardDetail = new MoneyBack();
        }
        else if (cardType == "Titaium")
        {
            cardDetail = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetail = new Platinium();
        }
        //sinon lancer une exception
        return cardDetail;
    }
}