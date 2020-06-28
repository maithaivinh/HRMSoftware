using HRMSoftware.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMSoftware.Infrastructure.Abstracts
{
    public abstract class HRMBaseEntity : IHasTracking
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
    }
}
