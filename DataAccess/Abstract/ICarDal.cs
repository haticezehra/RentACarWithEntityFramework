﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepository<Car>
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        public List<Car> GetById(int id);
        public List<Car> GetCarsByBrandId(int brandId);
        public List<Car> GetCarsByColorId(int colorId)
        

    }
}
