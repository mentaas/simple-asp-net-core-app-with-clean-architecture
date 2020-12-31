using AbcTestApp.Domain.Entities.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Domain.Interfaces
{
    public interface ILocationRepository
    {
        Location GetLocation(int id);
        IEnumerable<Location> GetLocations();
        Location Add(Location location);
        void Edit(Location location);
        void Delete(Location location);
    }
}
