using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory<ICar>.Register(1, () => RaceCar.Instance);
            Factory<ICar>.Register(2, () => PrivateCar.Instance);
            Console.ReadKey();
        }
    }
}
