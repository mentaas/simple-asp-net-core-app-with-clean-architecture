using AbcTestApp.SharedModel.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbcTestApp.SharedModel.Locations
{
    public class EditLocationModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        public int CityId { get; set; }
        public IEnumerable<CityModel> Cities { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
