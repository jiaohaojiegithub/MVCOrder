namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("handoperator")]
    public partial class handoperator
    {
        public int id { get; set; }

        [Column("operator")]
        [StringLength(20)]
        public string _operator { get; set; }

        [StringLength(20)]
        public string computer { get; set; }

        public DateTime? optime { get; set; }
    }
}
