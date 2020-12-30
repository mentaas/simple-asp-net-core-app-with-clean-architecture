using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Domain.Kernel
{
    public interface IDeleteData
    {
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
