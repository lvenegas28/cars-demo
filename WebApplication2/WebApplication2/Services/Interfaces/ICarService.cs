using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Interfaces
{
    public interface ICarService
    {
        ICollection<CarModel> GetCars();
        bool CreateCar(CarModel car);     
    }
}
