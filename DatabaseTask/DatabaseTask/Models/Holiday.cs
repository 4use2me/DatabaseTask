using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Holiday
    {
        [Key]
        public int HolidayID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Comment { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
