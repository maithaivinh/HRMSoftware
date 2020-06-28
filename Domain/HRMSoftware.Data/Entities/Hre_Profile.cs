using HRMSoftware.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace HRMSoftware.Data.Entities
{
    [Table("Hre_Profiles")]
    public class Hre_Profile : HRMBaseEntity
    {
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        [Required]
        public string CodeEmp { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        [Required]
        public string ProfileName { get; set; }
        public Guid OrgStructureID { get; set; }
        public Nullable<Guid> PositionID { get; set; }
        public Nullable<Guid> JobTitleID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        [Required]
        public string Gender { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string PlaceOfBirth { get; set; }
        public Nullable<DateTime> DateHire { get; set; }
        public Nullable<DateTime> DateQuit { get; set; }
    }
}
