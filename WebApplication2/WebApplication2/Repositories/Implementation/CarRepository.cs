using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DataAccess;
using WebApplication2.Models;
using WebApplication2.Repositories.Interfaces;

namespace WebApplication2.Repositories.Implementation
{
    /// <summary>
    /// Database operations must be here.
    /// </summary>
    public class CarRepository : ICarRepository
    {
        public CarRepository() { }

        // Inserts a new car
        public void AddCar(CarModel car)
        {
            CarsDatabaseContext.AddCar(car);
        }

        // Returns cars from database
        public ICollection<CarModel> GetCars()
        {
            return CarsDatabaseContext.Cars;
        }
    
    }
}