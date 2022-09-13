namespace BuilderEx.builder;

public class CoffeBuilder: BeverageBuilder
{
    public override void SetWater()
    {
        Console.WriteLine("Faire bouillir de l'eau");
        GetBeverage().Water = 40;
    }

    public override void SetMilk()
    {
        Console.WriteLine("Etape 2 : Ajouter du lait");
        GetBeverage().Milk = 50;
    }

    public override void SetSugar()
    {
        Console.WriteLine("Etape 3 : AJouter du sucre");
        GetBeverage().Sugar = 10;
    }

    public override void SetPowderQuantity()
    {
        Console.WriteLine("Etape 4: Ajout de 15 gramme de poudre");
        GetBeverage().PowderQuantity = 15;
    }

    public override void SetBeverageType()
    {
        Console.WriteLine("Café");
        GetBeverage().BeverageName = "Café";
    }
}