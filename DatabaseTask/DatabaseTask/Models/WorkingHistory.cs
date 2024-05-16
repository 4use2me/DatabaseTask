using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class WorkingHistory
    {
        [Key]
        public int WorkingHistoryID { get; set; }
        public int JobTitleID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeID { get; set; }
        public string Comment { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
        public virtual JobTitle JobTitle { get; set; } = null!;
    }
}
