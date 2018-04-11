namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class out_park_history
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

        public int? car_tid { get; set; }

        [StringLength(15)]
        public string carno { get; set; }

        public DateTime? out_time { get; set; }

        [StringLength(30)]
        public string out_pic { get; set; }

        public int? out_from { get; set; }

        [StringLength(30)]
        public string ident_pic { get; set; }

        public decimal? money1 { get; set; }

        public decimal? money2 { get; set; }

        public decimal? balance { get; set; }

        public int? open_gate_mode { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public int? rectype { get; set; }

        public int? isvalid { get; set; }

        public int? park_no { get; set; }

        public int? inside_park { get; set; }

        [StringLength(20)]
        public string invoice { get; set; }

        public DateTime? in_time { get; set; }

        public DateTime? update_time { get; set; }
    }
}
