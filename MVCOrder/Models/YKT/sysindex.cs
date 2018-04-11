namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysindex")]
    public partial class sysindex
    {
        [Key]
        [StringLength(10)]
        public string code { get; set; }

        public int? sequ { get; set; }
    }
}
