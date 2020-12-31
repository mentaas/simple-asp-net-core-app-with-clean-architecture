using AbcTestApp.Domain.Entities.Locations;
using AbcTestApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcTestApp.Infrastructure.Data.Repositories
{
    public class LocationRespository : ILocationRepository
    {
        private readonly IRepository<Location> _repository;

        public LocationRespository(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public Location Add(Location location)
        {
            return _repository.Create(location);
        }

        public void Delete(Location location)
        {
            _repository.Update(location);
        }

        public void Edit(Location location)
        {
            _repository.Update(location);
        }

        public Location GetLocation(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Location> GetLocations()
        {
            return _repository.GetAll().Where(_ => !_.IsDeleted);
        }
    }
}
