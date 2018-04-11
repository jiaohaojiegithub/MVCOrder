namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Time
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeNo { get; set; }

        [StringLength(50)]
        public string TimeName { get; set; }

        [StringLength(10)]
        public string bDate { get; set; }

        [StringLength(10)]
        public string eDate { get; set; }

        public int? NextTimeNo { get; set; }

        [StringLength(7)]
        public string Week { get; set; }

        [StringLength(8)]
        public string Time11 { get; set; }

        [StringLength(8)]
        public string Time12 { get; set; }

        [StringLength(8)]
        public string Time21 { get; set; }

        [StringLength(8)]
        public string Time22 { get; set; }

        [StringLength(8)]
        public string Time31 { get; set; }

        [StringLength(8)]
        public string Time32 { get; set; }
    }
}
