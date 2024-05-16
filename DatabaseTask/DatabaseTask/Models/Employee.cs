using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int PersonalIdentificationCode { get; set; }
        public string Address { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public int ContactPhone { get; set; }
        public string EmailAddress { get; set; } = null!;
        public int JobTitleID { get; set; }
        public int BranchOfficeID { get; set; }
        public DateTime WorkingSince { get; set; }
        public DateTime? WorkingUntil { get; set; }
        public string? Comment { get; set; }

        public virtual ICollection<AccessPermission> AccessPermissions { get; set; } = null!;
        public virtual ICollection<HealthInspection> HealthInspections { get; set; } = null!;
        public virtual ICollection<Renting> Rentings { get; set; } = null!;
        public virtual ICollection<Holiday> Holidays { get; set; } = null!;
        public virtual ICollection<Request> Requests { get; set; } = null!;
        public virtual ICollection<SickLeave> SickLeaves { get; set; } = null!;
        public virtual ICollection<ParentChild> ParentChildren { get; set; } = null!;
        public virtual ICollection<WorkingHistory> WorkingHistories { get; set; } = null!;
        public virtual JobTitle JobTitle { get; set; } = null!;
        public virtual BranchOffice BranchOffice { get; set; } = null!;
    }
}
