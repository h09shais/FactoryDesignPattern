namespace FactoryDesignPattern
{
    //Abstract Factory
    public interface IFactory<T>
    {
        T Create(object context);
    }
}
