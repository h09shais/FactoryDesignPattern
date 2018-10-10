using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface ICarProcessor
    {
        Task ProcessCarsForRace(ICar car);
    }
}
