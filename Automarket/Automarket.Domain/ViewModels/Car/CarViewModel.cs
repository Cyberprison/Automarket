using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public double Speed { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreate { get; set; }

        public string TypeCar { get; set; }
    }
}
