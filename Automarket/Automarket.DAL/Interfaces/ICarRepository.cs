using Automarket.Domain.Entity;
using System.Threading.Tasks;

namespace Automarket.DAL.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Task<Car> GetByName(string name);
    }
}
