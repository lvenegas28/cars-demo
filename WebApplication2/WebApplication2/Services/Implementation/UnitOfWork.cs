using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DataAccess;
using WebApplication2.Repositories.Implementation;
using WebApplication2.Repositories.Interfaces;
using WebApplication2.Services.Interfaces;

namespace WebApplication2.Services.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {        
        public ICarRepository CarRepository => new CarRepository();

        public bool CommitChanges()
        {
            return CarsDatabaseContext.Save();
        }
    }
}