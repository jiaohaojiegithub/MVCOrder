namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class xg_line
    {
        [Key]
        public int line_no { get; set; }

        [StringLength(30)]
        public string line_name { get; set; }
    }
}
