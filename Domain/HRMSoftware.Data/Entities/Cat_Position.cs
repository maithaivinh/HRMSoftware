using HRMSoftware.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HRMSoftware.Data.Entities
{
    [Table("Cat_Positions")]
    public class Cat_Position : HRMBaseEntity
    {
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        [Required]
        public string Code { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        [Required]
        public string PositionName { get; set; }
        public string PositionNameEn { get; set; }
    }
}
