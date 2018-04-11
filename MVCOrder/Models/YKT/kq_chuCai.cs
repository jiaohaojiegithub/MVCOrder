namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_chuCai
    {
        public int ID { get; set; }

        public int? custNo { get; set; }

        public DateTime? startDT { get; set; }

        public DateTime? endDT { get; set; }

        public int? howTime { get; set; }

        [StringLength(10)]
        public string Operator { get; set; }

        public DateTime? createDT { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }
    }
}
