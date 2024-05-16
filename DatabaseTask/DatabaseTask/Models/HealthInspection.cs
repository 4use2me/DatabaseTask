using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class HealthInspection
    {
        [Key]
        public int HealthInspectionID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime? LastInspection { get; set; }
        public DateTime NewInspectionDue { get; set; }
        public string Comment { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
    }
}
