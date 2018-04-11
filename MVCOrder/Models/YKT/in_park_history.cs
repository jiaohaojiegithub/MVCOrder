namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class in_park_history
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int in_seq { get; set; }

        public int? card_tid { get; set; }

        [StringLength(15)]
        public string carno { get; set; }

        public DateTime? in_time { get; set; }

        [StringLength(30)]
        public string in_pic { get; set; }

        public int? in_from { get; set; }

        public int? open_gate_mode { get; set; }

        public int? stall_in_use { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public int? rectype { get; set; }

        public int? park_no { get; set; }

        public int? inside_park { get; set; }

        public DateTime? update_time { get; set; }
    }
}
