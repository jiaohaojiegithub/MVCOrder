namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Card_quit_Pay
    {
        public int? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CardNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustNO { get; set; }

        public decimal? PrevAmt { get; set; }

        public decimal? AddAmt { get; set; }

        public DateTime? ValidTime { get; set; }

        [StringLength(10)]
        public string Operator { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        public DateTime? CreateDT { get; set; }
    }
}
