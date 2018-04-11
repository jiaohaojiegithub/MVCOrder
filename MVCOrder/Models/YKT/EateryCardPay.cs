namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryCardPay")]
    public partial class EateryCardPay
    {
        public int ID { get; set; }

        public int CardNO { get; set; }

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
