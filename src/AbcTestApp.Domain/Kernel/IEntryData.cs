using System;
using System.Collections.Generic;
using System.Text;

namespace AbcTestApp.Domain.Kernel
{
    public interface IEntryData
    {
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
    }
}
