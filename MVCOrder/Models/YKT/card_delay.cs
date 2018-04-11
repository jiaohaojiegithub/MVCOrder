namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class card_delay
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime prevdate { get; set; }

        public DateTime? currdate { get; set; }

        public decimal? money { get; set; }

        [StringLength(30)]
        public string remark { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public DateTime? createdt { get; set; }
    }
}
