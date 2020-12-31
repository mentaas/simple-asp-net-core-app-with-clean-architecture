using AbcTestApp.Domain.Entities.Cities;
using AbcTestApp.Domain.Kernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbcTestApp.Domain.Entities.Locations
{
    public class Location : BaseEntity, IEntryData, IUpdateData, IDeleteData
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public bool IsDeleted { get; set; }

        [MaxLength(150)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        [MaxLength(150)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [MaxLength(150)]
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
