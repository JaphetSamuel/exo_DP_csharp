﻿namespace FactoryMethod;

public class Titanium : ICreditCard
{
    public string GetCardType()
    {
        return "Titanium Edge";
    }

    public int GetCreditLimit()
    {
        return 2500;
    }

    public int GetAnnualCharge()
    {
        return 1500;
    }
}