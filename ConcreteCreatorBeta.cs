namespace FactoryDesignPattern;

public class ConcreteCreatorBeta : Creator
{
    public override IProduct FactoryMethod() =>
        new ConcreteProductBeta();
}
