using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class BranchOffice
    {
        [Key]
        public int BranchOfficeID { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public int ContactPhone { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string? Comment { get; set; }
        public int FirmID { get; set; }

        public virtual Firm Firm { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; } = null!;
    }
}
