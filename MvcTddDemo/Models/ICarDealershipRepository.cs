﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTddDemo.Models
{
    public interface ICarDealershipRepository
    {
        IEnumerable<Car> GetAllCars();       
    }
}