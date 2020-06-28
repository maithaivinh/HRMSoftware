using HRMSoftware.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HRMSoftware.Data.Entities
{
    public class Cat_JobTitle : HRMBaseEntity
    {
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        [Required]
        public string Code { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        [Required]
        public string JobTitleName { get; set; }
        public string JobTitleNameEn { get; set; }
    }
}
