namespace FactoryMethod.Factory;

public class MoneyBackFactory: CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new MoneyBack();
        return product;
    }
}

public class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new Titanium();
        return product;
    }
}

public class PlatinumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new Platinium();
        return product;
    }
}