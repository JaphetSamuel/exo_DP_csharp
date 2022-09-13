// See https://aka.ms/new-console-template for more information
using BuilderEx.builder;

namespace BuilderEx;

public class Program
{
    static void Main(string[] args)
    {
        Beverage beverage;
        BeverageDirector beverageDirector = new BeverageDirector();
            
        TeeBuilder tea = new TeeBuilder();
        beverage = beverageDirector.MakeBeverage(tea);
        Console.WriteLine(beverage.ShowBeverage());
        CoffeBuilder coffee = new CoffeBuilder();
        beverage = beverageDirector.MakeBeverage(coffee);
        Console.WriteLine(beverage.ShowBeverage());
        Console.ReadKey();
    }
}