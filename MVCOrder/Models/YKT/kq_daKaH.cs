namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_daKaH
    {
        public int id { get; set; }

        public int? custNo { get; set; }

        public DateTime? daKaDT { get; set; }

        public int? IsQianKa { get; set; }

        [StringLength(50)]
        public string doorName { get; set; }
    }
}
