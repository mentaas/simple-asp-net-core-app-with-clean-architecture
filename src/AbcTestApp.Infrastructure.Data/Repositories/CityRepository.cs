using AbcTestApp.Domain.Entities.Cities;
using AbcTestApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcTestApp.Infrastructure.Data.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly IRepository<City> _repository;

        public CityRepository(IRepository<City> repository)
        {
            _repository = repository;
        }

        public IEnumerable<City> GetCities()
        {
            return _repository.GetAll().Where(_ => !_.IsDeleted);
        }

        public City GetCity(int id)
        {
            return _repository.GetById(id);
        }
    }
}
