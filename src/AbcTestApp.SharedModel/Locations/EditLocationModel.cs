using AbcTestApp.SharedModel.Cities;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [Required]
        public int? CityId { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }
        [Required]
        public double? Longitude { get; set; }
        [Required]
        public double? Latitude { get; set; }
    }
}
