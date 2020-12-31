using AbcTestApp.Domain.Entities.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Domain.Interfaces
{
    public interface ICityRepository
    {
        City GetCity(int id);
        IEnumerable<City> GetCities();
    }
}
