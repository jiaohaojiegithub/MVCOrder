namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_log
    {
        public int id { get; set; }

        public int? Rstart { get; set; }

        public int? Rend { get; set; }

        public bool? IsClear { get; set; }

        [StringLength(10)]
        public string Operator { get; set; }

        public DateTime? opTime { get; set; }
    }
}
