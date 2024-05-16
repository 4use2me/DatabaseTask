using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public partial class Hint
    {
        [Key]
        public int HintID { get; set; }
        public string Description { get; set; } = null!;
        public string? Comment { get; set; }
    }
}
