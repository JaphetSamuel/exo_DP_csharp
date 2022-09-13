namespace FactoryMethod;

public class Platinium: ICreditCard
{
    public string GetCardType()
    {
        return "Platinium plus";
    }

    public int GetCreditLimit()
    {
        return 3500;
    }

    public int GetAnnualCharge()
    {
        return 2500;
    }
}