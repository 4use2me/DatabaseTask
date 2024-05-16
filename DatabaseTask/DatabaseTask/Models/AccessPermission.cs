using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class AccessPermission
    {
        [Key]
        public int AccessPermissionID { get; set; }
        public int PermissionNr { get; set; }
        public int EmployeeID { get; set; }
        public int JobTitleID { get; set; }
        public DateTime ValidSince { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string Comment { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
        public virtual JobTitle JobTitle { get; set; } = null!;
    }
}
