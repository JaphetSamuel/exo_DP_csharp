namespace AbstractFactory;

public class LandAnimalFactory: AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        if (animalType == "Dog")
        {
            return new Dog();
        } 
        if (animalType ==  "Cat"){
            return new Cat();
        }
        else if (animalType == "Lion")
        {
            return new Lion();
        }
        else
        {
            return null;
        }
    }
}