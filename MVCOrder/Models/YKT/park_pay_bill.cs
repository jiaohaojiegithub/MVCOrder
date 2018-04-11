namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class park_pay_bill
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long billNo { get; set; }

        [StringLength(15)]
        public string carNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long inSeq { get; set; }

        public int? userType { get; set; }

        public int? carType { get; set; }

        public DateTime? inTime { get; set; }

        public DateTime? outTime { get; set; }

        public decimal? money { get; set; }

        public decimal? discountM { get; set; }

        public decimal? paidM { get; set; }

        public int? payMode { get; set; }

        public int? recStatus { get; set; }

        public int? isVip { get; set; }

        public DateTime? payTime { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public int? isHandOver { get; set; }
    }
}
