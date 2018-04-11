namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("device")]
    public partial class device
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dev_id { get; set; }

        [StringLength(30)]
        public string dev_name { get; set; }

        public int? dev_tid { get; set; }

        public int? park_no { get; set; }

        public int? inside_park { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string computer { get; set; }

        [StringLength(60)]
        public string location { get; set; }

        public int? loopcheck { get; set; }
    }
}
