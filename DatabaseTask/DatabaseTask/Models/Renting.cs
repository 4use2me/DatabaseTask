using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Renting
    {
        [Key]
        public int RentingID { get; set; }
        public int ObjectID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
        public virtual Object Object { get; set; } = null!;
    }
}
