using AbcTestApp.Application.Interfaces;
using AbcTestApp.Domain.Interfaces;
using AbcTestApp.SharedModel.Cities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Application.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _repository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public CityModel Get(int id)
        {
            var model = 
            _mapper.Map<CityModel>(_repository.GetCity(id));
            return model;
        }

        public IEnumerable<CityModel> GetAll()
        {
            return _mapper.Map<List<CityModel>>(_repository.GetCities());
        }
    }
}
