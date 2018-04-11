namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("park")]
    public partial class park
    {
        [Key]
        public int park_no { get; set; }

        [StringLength(20)]
        public string park_name { get; set; }

        public int? park_type { get; set; }

        public int? belong_to { get; set; }

        public int? all_stall { get; set; }

        public int? free_stall { get; set; }

        [StringLength(60)]
        public string remark { get; set; }
    }
}
