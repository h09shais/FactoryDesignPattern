using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CarProcessor : ICarProcessor
    {
        private readonly ICarRepository _carRepository;

        public CarProcessor(ICarRepository carRepository)
        {
            this._carRepository = carRepository;
        }
        public Task ProcessCarsForRace(ICar car)
        {
            throw new System.NotImplementedException();
        }
    }
}
