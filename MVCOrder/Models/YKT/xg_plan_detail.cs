namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class xg_plan_detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int plan_no { get; set; }

        public int? line_no { get; set; }

        public int? node_no { get; set; }

        [StringLength(10)]
        public string door_sn { get; set; }

        [StringLength(50)]
        public string node_name { get; set; }

        [StringLength(2)]
        public string door_readno { get; set; }

        public DateTime? Start_dt { get; set; }

        public DateTime? End_dt { get; set; }
    }
}
