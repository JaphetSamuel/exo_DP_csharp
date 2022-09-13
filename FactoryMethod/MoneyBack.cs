namespace FactoryMethod;

public class MoneyBack: ICreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }

    public int GetCreditLimit()
    {
        return 1500;
    }

    public int GetAnnualCharge()
    {
        return 500;
    }
}