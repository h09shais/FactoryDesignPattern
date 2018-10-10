using System.Collections.Generic;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface ICarRepository
    {
       Task<IEnumerable<ICar>> GetRacingCars();
    }
}
