namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class park_central_pay
    {
        [StringLength(15)]
        public string carNo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long inSeq { get; set; }

        public int? userType { get; set; }

        public int? carType { get; set; }

        public int? in_from { get; set; }

        public DateTime? inTime { get; set; }

        [StringLength(100)]
        public string in_pic { get; set; }

        public decimal? money { get; set; }

        public decimal? discountM { get; set; }

        public decimal? paidM { get; set; }

        public DateTime? payTime { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        [StringLength(50)]
        public string ComputerName { get; set; }

        [StringLength(50)]
        public string PayMethod { get; set; }

        public int? isHandOver { get; set; }
    }
}
