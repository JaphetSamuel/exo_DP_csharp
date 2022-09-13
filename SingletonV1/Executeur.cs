namespace SingletonV1;

public sealed class Executeur
{
    private static int counter = 0;
    private static Executeur? _executeur = null;

    public static Executeur GetExecuteur
    {
        get
        {
            if (_executeur == null)
            {
                return new Executeur();
            }

            return _executeur;
        }
    }

    private Executeur()
    {
        counter++;
        Console.WriteLine("counter est :" + counter);
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}