namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hmd_list
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dev_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        public int? card_type { get; set; }

        public int? car_type { get; set; }

        public int? park_stall { get; set; }

        public int? timesec { get; set; }

        public DateTime? validdt { get; set; }

        [StringLength(15)]
        public string carno { get; set; }

        public int? status { get; set; }

        public int? cust_no { get; set; }
    }
}
