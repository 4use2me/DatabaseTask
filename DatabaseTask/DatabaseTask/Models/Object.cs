using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Object
    {
        [Key]
        public int ObjectID { get; set; }
        public string ObjectLocation { get; set; } = null!;
        public DateTime PurchasingDate { get; set; }
        public string? History { get; set; }
        public string Comment { get; set; } = null!;

        public virtual ICollection<Renting> Rentings { get; set; } = null!;
    }
}
