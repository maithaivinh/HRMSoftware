using HRMSoftware.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace HRMSoftware.Data.Entities
{
    public class Hre_Profile : HRMBaseEntity
    {
        public string CodeEmp { get; set; }
        public string ProfileName { get; set; }
        public Guid OrgStructureID { get; set; }
        public Nullable<Guid> PositionID { get; set; }
        public Nullable<Guid> JobTitleID { get; set; }
        public string Gender { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public Nullable<DateTime> DateHire { get; set; }
        public Nullable<DateTime> DateQuit { get; set; }
        public virtual Cat_Position Position { get; set; }
        public virtual Cat_JobTitle JobTitle { get; set; }
    }
}
