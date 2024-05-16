using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Request
    {
        [Key]
        public int RequestID { get; set; }
        public int EmployeeID { get; set; }
        public string Description { get; set; } = null!;
        public string? Comment { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
