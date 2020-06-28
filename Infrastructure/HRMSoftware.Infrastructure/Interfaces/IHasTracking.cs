using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSoftware.Infrastructure.Interfaces
{
    public interface IHasTracking
    {
        public Guid ID { get; set; }
        DateTime DateCreate { get; set; }
        DateTime DateUpdate { get; set; }
        string UserCreate { get; set; }
        string UserUpdate { get; set; }
    }
}
