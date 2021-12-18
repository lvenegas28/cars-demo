using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Repositories.Interfaces;

namespace WebApplication2.Services.Interfaces
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository { get; }
        bool CommitChanges();        
    }
}