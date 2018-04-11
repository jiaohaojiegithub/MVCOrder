namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("log")]
    public partial class log
    {
        [Key]
        public int log_id { get; set; }

        public DateTime? log_date { get; set; }

        public int? log_type { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }
    }
}
