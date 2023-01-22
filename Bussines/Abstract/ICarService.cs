﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
      public  List<Car> GetAll();
        public List<Car> GetCarsByBrandId(int id);
        public List<Car> GetCarsByColorId(int id);
    }
}
