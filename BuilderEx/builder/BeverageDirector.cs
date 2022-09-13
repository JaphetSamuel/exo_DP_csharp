namespace BuilderEx.builder;

public class BeverageDirector
{
    public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
    {
        beverageBuilder.CreateBeverage();
        beverageBuilder.SetMilk();
        beverageBuilder.SetSugar();
        beverageBuilder.SetWater();
        beverageBuilder.SetBeverageType();
        beverageBuilder.SetPowderQuantity();

        return beverageBuilder.GetBeverage();
    }
}