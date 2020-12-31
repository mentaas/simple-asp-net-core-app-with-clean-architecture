using AbcTestApp.Application.Interfaces;
using AbcTestApp.Application.Services;
using AbcTestApp.Domain.Interfaces;
using AbcTestApp.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //AbcTestApp.Application
            services.AddScoped<IAdministrationService, AdministrationService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<ICityService, CityService>();

            //AbcTestApp.Domain.Interfaces | AbcTestApp.Infrastructure.Data.Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ILocationRepository, LocationRespository>();
            services.AddScoped<ICityRepository, CityRepository>();
        }
    }
}
