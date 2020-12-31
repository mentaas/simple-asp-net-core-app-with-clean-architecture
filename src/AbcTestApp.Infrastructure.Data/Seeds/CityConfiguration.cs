using AbcTestApp.Domain.Entities.Cities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Infrastructure.Data.Seeds
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {

            builder.HasData(
                    new City
                    {
                        Id = 1,
                        Name = "Berlin"
                    },
                    new City
                    {
                        Id = 2,
                        Name = "Amsterdam"
                    },
                    new City
                    {
                        Id = 3,
                        Name = "Ljubljana"
                    },
                    new City
                    {
                        Id = 4,
                        Name = "Belgrade"
                    },
                    new City
                    {
                        Id = 5,
                        Name = "Zagreb"
                    },
                    new City
                    {
                        Id = 6,
                        Name = "Sarajevo"
                    },
                    new City
                    {
                        Id = 7,
                        Name = "Prishtina"
                    },
                    new City
                    {
                        Id = 8,
                        Name = "Rome"
                    },
                    new City
                    {
                        Id = 9,
                        Name = "Paris"
                    },
                    new City
                    {
                        Id = 10,
                        Name = "Madrid"
                    },
                    new City
                    {
                        Id = 11,
                        Name = "Istanbul"
                    },
                    new City
                    {
                        Id = 12,
                        Name = "Moscow"
                    },
                    new City
                    {
                        Id = 13,
                        Name = "Stockholm"
                    }
                );
        }
    }
}
