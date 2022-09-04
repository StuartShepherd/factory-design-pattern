namespace FactoryDesignPattern;

public class ConcreteCreatorAlpha : Creator
{
    public override IProduct FactoryMethod() =>
        new ConcreteProductAlpha();
}
