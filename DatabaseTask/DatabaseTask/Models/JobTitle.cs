using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class JobTitle
    {
        [Key]
        public int JobTitleID { get; set; }
        public string Title { get; set; } = null!;
        public int Code { get; set; }
        public string Unit { get; set; } = null!;
        public string Comment { get; set; } = null!;

        public virtual ICollection<AccessPermission> AccessPermissions { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; } = null!;
        public virtual ICollection<WorkingHistory> WorkingHistories { get; set; } = null!;
    }
}
