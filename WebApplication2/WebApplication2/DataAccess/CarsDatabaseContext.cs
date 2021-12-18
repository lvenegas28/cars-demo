using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DataAccess
{
    public static class CarsDatabaseContext
    {
        public static ICollection<CarModel> Cars = new List<CarModel>
        {
            new CarModel { Brand = "Toyota", Model = "Corolla", Year = 2019 },
            new CarModel { Brand = "Honda", Model = "Accord", Year = 2020 },
            new CarModel { Brand = "Ford", Model = "F-150", Year = 2021 }
        };

        public static void AddCar(CarModel car)
        {
            Cars.Add(car);
        }

        /// <summary>
        /// Simulates saving on database
        /// </summary>
        /// <returns>Always true</returns>
        public static bool Save()
        {
            return true;
        }
    }
}