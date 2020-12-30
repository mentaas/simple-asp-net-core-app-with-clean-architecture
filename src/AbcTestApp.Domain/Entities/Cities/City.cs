using AbcTestApp.Domain.Kernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbcTestApp.Domain.Entities.Cities
{
    public class City : BaseEntity, IEntryData, IUpdateData, IDeleteData
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        [MaxLength(150)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        [MaxLength(150)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required]
        [MaxLength(150)]
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
