namespace AbstractFactory;

public abstract class AnimalFactory
{
    public abstract IAnimal GetAnimal(String animalType);

    public static AnimalFactory CreateAnimalFactory(string factoryType)
    {
        if (factoryType == "Sea")
        {
            return new SeaAnimalFactory();
        }
        else
        {
            return new LandAnimalFactory();
        }
    }
}
