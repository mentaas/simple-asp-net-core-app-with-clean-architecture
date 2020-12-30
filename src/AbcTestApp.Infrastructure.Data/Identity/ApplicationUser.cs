using AbcTestApp.Domain.Kernel;
using AbcTestApp.Domain.Entities.Cities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using AbcTestApp.Domain.Entities.Locations;

namespace AbcTestApp.Infrastructure.Data.Identity
{
    public class ApplicationUser : IdentityUser, IEntryData, IUpdateData, IDeleteData
    {
        //public int CityId { get; set; }
        //public virtual City City { get; set; }
        //public int HomeLocationId { get; set; }
        //public virtual Location HomeLocation { get; set; }
        //public int WorkLocationId { get; set; }
        //public virtual Location WorkLocation { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
