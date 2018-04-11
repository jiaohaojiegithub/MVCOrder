namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("parking")]
    public partial class parking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long in_seq { get; set; }

        public int? card_tid { get; set; }

        public int? car_tid { get; set; }

        [StringLength(15)]
        public string carno { get; set; }

        public DateTime? in_time { get; set; }

        [StringLength(100)]
        public string in_pic { get; set; }

        public int? in_from { get; set; }

        public int? stall_no { get; set; }

        public int? inside_park { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        [StringLength(150)]
        public string small_pic { get; set; }

        public int? feesFlag { get; set; }

        public DateTime? payTime { get; set; }

        public decimal? central_pay_money { get; set; }

        public int isfee { get; set; }

        public int park_no { get; set; }

        [Required]
        [StringLength(20)]
        public string CapturePlate { get; set; }

        public bool upLoadFlag { get; set; }
    }
}
