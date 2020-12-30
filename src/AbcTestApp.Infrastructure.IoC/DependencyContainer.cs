using AbcTestApp.Application.Interfaces;
using AbcTestApp.Application.Services;
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

            //AbcTestApp.Domain.Interfaces | AbcTestApp.Infra.Data.Repositories
            //services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
