using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Domain.Kernel
{
    public interface IUpdateData
    {
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}
