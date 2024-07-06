using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Automarket.Domain.Response;
using System.Threading.Tasks;
using Automarket.Domain.Entity;
using Automarket.Domain.ViewModels.Car;

namespace Automarket.Service.Interfaces
{
    public interface ICarService
    {
        Task<BaseResponse<IEnumerable<Car>>> GetCars();

        Task<BaseResponse<Car>> GetCar(int id);

        Task<BaseResponse<bool>> DeleteCar(int id);

        Task<BaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);

        Task<BaseResponse<Car>> GetCarByName(string name);

        Task<BaseResponse<Car>> Edit(int id, CarViewModel model);
    }
}
