namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class park_timesec
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int timeid { get; set; }

        [StringLength(20)]
        public string timename { get; set; }

        [StringLength(8)]
        public string timesec1 { get; set; }

        [StringLength(8)]
        public string timesec2 { get; set; }

        [StringLength(16)]
        public string timedate { get; set; }

        public int? satrest { get; set; }

        public int? sunrest { get; set; }
    }
}
