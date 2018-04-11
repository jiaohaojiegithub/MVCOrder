namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_controlStall
    {
        [Key]
        public int stallNo { get; set; }

        [StringLength(40)]
        public string sName { get; set; }

        [StringLength(250)]
        public string remark { get; set; }

        public int? PID { get; set; }
    }
}
