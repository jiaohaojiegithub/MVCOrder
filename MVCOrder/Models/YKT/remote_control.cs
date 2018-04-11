namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class remote_control
    {
        [Key]
        [Column(Order = 0)]
        public DateTime indt { get; set; }

        [Key]
        [Column("operator", Order = 1)]
        [StringLength(10)]
        public string _operator { get; set; }

        public int? comm_type { get; set; }

        public int? address { get; set; }

        public int? flag { get; set; }

        [StringLength(100)]
        public string picture { get; set; }

        public int? isHandOver { get; set; }

        [StringLength(50)]
        public string allowFree { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool upLoadFlag { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int upLoadCount { get; set; }
    }
}
