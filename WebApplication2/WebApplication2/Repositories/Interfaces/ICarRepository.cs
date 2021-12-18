using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repositories.Interfaces
{
    public interface ICarRepository
    {
        ICollection<CarModel> GetCars();
        void AddCar(CarModel car);        
    }
}
