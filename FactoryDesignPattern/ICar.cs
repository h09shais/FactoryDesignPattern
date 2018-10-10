namespace FactoryDesignPattern
{
    public interface ICar
    {
        Tires Tires { get; set; }
        SteeringWheel SteeringWheel { get; set; }
        Engine Engine { get; set; }
    }
}
