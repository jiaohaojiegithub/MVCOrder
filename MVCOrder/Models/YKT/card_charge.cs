namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class card_charge
    {
        public int ID { get; set; }

        public int? SystemId { get; set; }

        public int? CardNO { get; set; }

        [StringLength(10)]
        public string CustName { get; set; }

        public decimal? PrevAmt { get; set; }

        public decimal? AddAmt { get; set; }

        [StringLength(10)]
        public string Operator { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        public DateTime? CreateDT { get; set; }
    }
}
