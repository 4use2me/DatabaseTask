using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class EmployeesChild
    {
        [Key]
        public int EmployeesChildID { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public int PersonalIdentificationCode { get; set; }
        public int Age { get; set; }
        public string? Comment { get; set; }

        public virtual ICollection<ParentChild> ParentChildren { get; set; } = null!;

    }
}
