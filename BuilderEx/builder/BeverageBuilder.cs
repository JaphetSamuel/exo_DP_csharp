namespace BuilderEx.builder;

public abstract class BeverageBuilder
{
    protected Beverage _beverage;

    public abstract void SetWater();
    public abstract void SetMilk();
    public abstract void SetSugar();
    public abstract void SetPowderQuantity();
    public abstract void SetBeverageType();

    public void CreateBeverage()
    {
        this._beverage = new Beverage();
    }

    public Beverage GetBeverage()
    {
        return _beverage;
    }
}