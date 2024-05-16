using System;
using System.Collections.Generic;

namespace DatabaseTask.Models
{
    public partial class ParentChild
    {
        public int EmployeeID { get; set; }
        public int EmployeesChildID { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual EmployeesChild EmployeesChild { get; set; } = null!;
    }
}
