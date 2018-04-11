namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvalidOpenGate")]
    public partial class InvalidOpenGate
    {
        [Key]
        public int gateopen_id { get; set; }

        public DateTime? gateopen_time { get; set; }

        public int? gateopen_address { get; set; }

        [StringLength(50)]
        public string gateopen_pic { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }
    }
}
