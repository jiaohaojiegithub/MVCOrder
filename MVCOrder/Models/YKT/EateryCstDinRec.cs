namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryCstDinRec")]
    public partial class EateryCstDinRec
    {
        public int ID { get; set; }

        public int? DinNo { get; set; }

        public int? CmpNo { get; set; }

        public int? DevNo { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public int? DayAddNo { get; set; }

        public int? CustNo { get; set; }

        public int? CustLevel { get; set; }

        public int? CardNo { get; set; }

        public decimal? amt { get; set; }

        public decimal? addAmt { get; set; }

        public decimal? realAmt { get; set; }

        public DateTime? CreateDT { get; set; }

        public decimal? leftAmt { get; set; }
    }
}
