namespace FactoryDesignPattern;

public class Client
{
    public void Main()
    {
        Console.WriteLine("ConcreteCreatorAlpha.");
        ClientCode(new ConcreteCreatorAlpha());

        Console.WriteLine();

        Console.WriteLine("ConcreteCreatorBeta.");
        ClientCode(new ConcreteCreatorBeta());
    }

    public void ClientCode(Creator creator) =>
        Console.WriteLine($"{creator.DoOperation()}");
}
