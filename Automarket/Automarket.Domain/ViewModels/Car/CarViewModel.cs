﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public double Speed { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreate { get; set; }

        public string TypeCar { get; set; }

        public IFormFile Avatar { get; set; }
    }
}
