// See https://aka.ms/new-console-template for more information

namespace  SingletonV1;

public class Program
{
    public static void Main(String[] args)
    {
        Executeur _executeur1 = Executeur.GetExecuteur;
        _executeur1.PrintMessage("Message de un");
        
        Executeur _executeur2 = Executeur.GetExecuteur;
        _executeur2.PrintMessage("message de 2");

        Console.ReadLine();
    }
}

