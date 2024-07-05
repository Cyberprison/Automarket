using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Automarket.Domain.Response;
using System.Threading.Tasks;
using Automarket.Domain.Entity;

namespace Automarket.Service.Interfaces
{
    public interface ICarService
    {
        Task<BaseResponse<IEnumerable<Car>>> GetCars();
    }
}
