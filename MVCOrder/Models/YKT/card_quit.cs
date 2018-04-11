namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class card_quit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        public int? retmode { get; set; }

        public decimal? foregift { get; set; }

        public decimal? balance { get; set; }

        public decimal? retmoney { get; set; }

        [StringLength(60)]
        public string remark { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public DateTime? createdt { get; set; }
    }
}
