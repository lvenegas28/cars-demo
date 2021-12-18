using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using WebApplication2.Services.Interfaces;

namespace WebApplication2.Services.Implementation
{
    public class CarService : ICarService
    {
        /// <summary>
        /// When dependency injection is configured this unit of work must be placed there.
        /// </summary>
        private readonly IUnitOfWork _uow = new UnitOfWork();

        public bool CreateCar(CarModel car)
        {
            _uow.CarRepository.AddCar(car);
            // This line will simulate save changes execution
            return _uow.CommitChanges();
        }

        public ICollection<CarModel> GetCars()
        {
            return _uow.CarRepository.GetCars();
        }
    }
}