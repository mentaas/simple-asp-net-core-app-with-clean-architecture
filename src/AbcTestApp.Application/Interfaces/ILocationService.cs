using AbcTestApp.SharedModel.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Application.Interfaces
{
    public interface ILocationService
    {
        LocationModel Save(NewLocationModel _);
        void Edit(EditLocationModel _);
        void Delete(int id);
        LocationModel Get(int id);
        IEnumerable<LocationModel> GetAll();
        NewLocationModel FillModel();
        EditLocationModel FillEditModel(int id);
        IEnumerable<LocationModel> GetLocationList();
    }
}
