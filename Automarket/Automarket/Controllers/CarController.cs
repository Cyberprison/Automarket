using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response1 = await _carRepository.Select();

            var response2 = await _carRepository.GetByName("Laba");

            var response3 = await _carRepository.Get(3);

            var car = new Car()
            {
                Name = "name",
                Description = "desc",
                Model = "model",
                Speed = 1,
                Price = 1,
                DateCreate = DateTime.Now
                //TypeCar
            };

            await _carRepository.Create(car);
            await _carRepository.Delete(car);

            return View(response1);
        }


    }
}