using AbcTestApp.SharedModel.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Application.Interfaces
{
    public interface ICityService
    {
        CityModel Get(int id);
        IEnumerable<CityModel> GetAll();
    }
}
