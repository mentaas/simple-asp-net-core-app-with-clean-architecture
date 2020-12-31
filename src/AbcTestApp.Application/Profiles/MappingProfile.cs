using AbcTestApp.Domain.Entities.Cities;
using AbcTestApp.Domain.Entities.Locations;
using AbcTestApp.Infrastructure.Data.Identity;
using AbcTestApp.SharedModel.Administrations.Users;
using AbcTestApp.SharedModel.Cities;
using AbcTestApp.SharedModel.Locations;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewUserModel, ApplicationUser>()
                .ReverseMap()
                .ForMember(x => x.ConfirmPassword, opt => opt.Ignore())
                .ForMember(x => x.Password, opt => opt.Ignore());

            CreateMap<EditLocationModel, Location>().ReverseMap();
            CreateMap<NewLocationModel, Location>().ReverseMap();
            CreateMap<LocationModel, Location>().ReverseMap();

            CreateMap<CityModel, City>().ReverseMap();
        }
    }
}
