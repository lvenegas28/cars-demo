using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DTOs;
using WebApplication2.Models;
using WebApplication2.Services.Implementation;
using WebApplication2.Services.Interfaces;

namespace WebApplication2.Controllers
{
    public class CarsController : Controller
    {
        /// <summary>
        /// When dependency injection is configured services must be configured there.
        /// </summary>
        private readonly ICarService _carService = new CarService();

        // GET: Cars
        public ActionResult Index()
        {            
            return View();
        }

        [HttpGet]
        public ActionResult GetCars()
        {
            var cars = _carService.GetCars();

            // Instead of use a loop, one good practice would be use automapper.
            var carsDto = new List<CarDTO>();
            foreach (var c in cars)
            {
                carsDto.Add(new CarDTO { Brand = c.Brand, Model = c.Model, Year = c.Year });
            }

            return Content(JsonConvert.SerializeObject(carsDto));
        }

        [HttpPost]
        public ActionResult Save(CarModel car)
        {
            if (car == null)
            {
                Response.StatusCode = 400;
                return Content("Invalid car information");
            }

            bool result = _carService.CreateCar(car);
            if (result)
            {
                var carDto = new CarDTO
                {
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year
                };
                return Content(JsonConvert.SerializeObject(carDto));
            }

            Response.StatusCode = 400;
            return Content("Car could be created");

        }
    }
}