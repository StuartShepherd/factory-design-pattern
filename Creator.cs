namespace FactoryDesignPattern;

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string DoOperation()
    {
        var product = FactoryMethod();
        return $"\tCreator: {product.Operation()}";
    }
}
