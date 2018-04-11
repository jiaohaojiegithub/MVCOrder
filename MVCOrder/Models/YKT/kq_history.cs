namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_history
    {
        public int id { get; set; }

        public int? riqi { get; set; }

        public DateTime? createDT { get; set; }

        public int? IsHistory { get; set; }
    }
}
