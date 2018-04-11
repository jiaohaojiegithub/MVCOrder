namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class park_stall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stall_no { get; set; }

        [StringLength(20)]
        public string stall_name { get; set; }

        public int? stall_num { get; set; }

        [StringLength(60)]
        public string remark { get; set; }
    }
}
