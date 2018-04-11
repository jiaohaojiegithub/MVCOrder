namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class card_make
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        public decimal? foregift { get; set; }

        public decimal? balance { get; set; }

        public DateTime? validdt { get; set; }

        public int? status { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public DateTime? createdt { get; set; }

        public DateTime? parkStartDT { get; set; }
    }
}
