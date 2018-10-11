namespace FactoryDesignPattern
{
    //Service Locator
    public interface IServiceLocator
    {
        T Create<T>(object context);
    }
}
