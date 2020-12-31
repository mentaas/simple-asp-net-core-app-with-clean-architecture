using AbcTestApp.Application.Interfaces;
using AbcTestApp.Domain.Entities.Locations;
using AbcTestApp.Domain.Interfaces;
using AbcTestApp.SharedModel.Locations;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _repository;
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public LocationService(ILocationRepository repository, ICityService cityService, IMapper mapper)
        {
            _repository = repository;
            _cityService = cityService;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            try
            {
                var location = _repository.GetLocation(id);

                if (location == null)
                    throw new NullReferenceException("Record dose not exist");

                _repository.Delete(location);
            }
            catch (Exception ex)
            {
                //here we will log this exception and show the user that some error was occurred
            }
        }

        public void Edit(EditLocationModel _)
        {
            try
            {
                var location = _repository.GetLocation(_.Id);
                _mapper.Map(_, location);

                if (location == null)
                    throw new NullReferenceException("Record dose not exist");

                _repository.Edit(location);
            }
            catch (Exception ex)
            {
                //here we will log this exception and show the user that some error was occurred
            }
        }

        public LocationModel Get(int id)
        {
            var model = 
            _mapper.Map<LocationModel>(_repository.GetLocation(id));
            return model;
        }

        public IEnumerable<LocationModel> GetAll()
        {
            return _mapper.Map<List<LocationModel>>(_repository.GetLocations());
        }

        public LocationModel Save(NewLocationModel _)
        {
            var entity = _repository.Add(_mapper.Map<Location>(_));
            var model = _mapper.Map<LocationModel>(entity);
            return model;
        }

        public NewLocationModel FillModel()
        {
            var model = new NewLocationModel();
            var list = new List<SelectListItem>();

            foreach (var city in _cityService.GetAll())
                list.Add(new SelectListItem(city.Name, city.Id.ToString()));
            model.Cities = list;

            return model;
        }

        public EditLocationModel FillEditModel(int id)
        {
            var model = _mapper.Map<EditLocationModel>(_repository.GetLocation(id));
            var list = new List<SelectListItem>();

            foreach (var city in _cityService.GetAll())
                list.Add(new SelectListItem(city.Name, city.Id.ToString()));
            model.Cities = list;

            return model;
        }

        public IEnumerable<LocationModel> GetLocationList()
        {
            var allLocs = _mapper.Map<List<LocationModel>>(_repository.GetLocations());

            foreach (var loc in allLocs)
            {
                loc.City = _cityService.Get(loc.CityId).Name;
            }

            return allLocs ?? new List<LocationModel>();
        }
    }
}
