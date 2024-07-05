using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);

        T Get(int id);

        //IEnumerable<T> Select();

        Task<List<T>> Select();

        bool Delete(T entity);
    }
}
