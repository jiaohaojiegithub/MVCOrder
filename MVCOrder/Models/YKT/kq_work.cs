namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_work
    {
        [Key]
        public int wrkNo { get; set; }

        [StringLength(20)]
        public string wrkName { get; set; }

        public int? wrkType { get; set; }

        [StringLength(5)]
        public string wrkStart1 { get; set; }

        [StringLength(5)]
        public string wrkEnd1 { get; set; }

        [StringLength(5)]
        public string wrkStart2 { get; set; }

        [StringLength(5)]
        public string wrkEnd2 { get; set; }

        [StringLength(5)]
        public string wrkStart3 { get; set; }

        [StringLength(5)]
        public string wrkEnd3 { get; set; }

        public int? wrkTime { get; set; }
    }
}
