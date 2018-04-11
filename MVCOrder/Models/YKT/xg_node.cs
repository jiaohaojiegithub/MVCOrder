namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class xg_node
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int node_no { get; set; }

        [StringLength(50)]
        public string node_name { get; set; }

        [StringLength(10)]
        public string door_sn { get; set; }

        [StringLength(2)]
        public string door_readno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int line_no { get; set; }
    }
}
