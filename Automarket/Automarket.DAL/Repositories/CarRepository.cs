using System.Collections.Generic;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Car entity)
        {
            throw new System.NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new System.NotImplementedException();
        }

        //public IEnumerable<Car> Select()
        //{
        //    return _db.Car;
        //}

        public Task<List<Car>> Select()
        {
            return _db.Car.ToListAsync();
        }

        public bool Delete(Car entity)
        {
            throw new System.NotImplementedException();
        }

        public Car GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
