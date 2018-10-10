using System.Collections.Generic;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CarRepository : ICarRepository
    {
        public Task<IEnumerable<ICar>> GetRacingCars()
        {
            throw new System.NotImplementedException();
        }
    }
}
