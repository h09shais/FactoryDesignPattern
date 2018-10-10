namespace FactoryDesignPattern
{
    public class Car : ICar
    {
        public Car(Engine engine, SteeringWheel wheel, Tires tires)
        {
            this.Engine = engine;
            this.SteeringWheel = wheel;
            this.Tires = tires;
        }

        public Tires Tires { get; set; }

        public SteeringWheel SteeringWheel { get; set; }

        public Engine Engine { get; set; }
    }
}
