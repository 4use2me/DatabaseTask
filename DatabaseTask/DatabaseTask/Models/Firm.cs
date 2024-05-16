using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Firm
    {
        [Key]
        public int FirmID { get; set; }
        public string Registry { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public int ContactPhone { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string? Comment { get; set; }

        public virtual ICollection<BranchOffice> BranchOffices { get; set; } = null!;
    }
}