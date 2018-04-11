namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_TimeTask
    {
        public int id { get; set; }

        [StringLength(4000)]
        public string devID { get; set; }

        [StringLength(5)]
        public string taskDT { get; set; }

        [StringLength(8)]
        public string taskTime { get; set; }

        public int? weekDy { get; set; }

        public int? Type { get; set; }
    }
}
