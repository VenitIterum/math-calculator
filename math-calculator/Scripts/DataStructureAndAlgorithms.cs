delegate void MessageInConsole();

public class DataStructureAndAlgorithmsClass
{
    MessageInConsole messageInConsole = () => Console.WriteLine("Something");

    internal void InternalMethod()
    {
        messageInConsole();
        Console.ReadKey();
    }
}