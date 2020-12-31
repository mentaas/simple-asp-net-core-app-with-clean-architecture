using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.SharedModel.Locations
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
