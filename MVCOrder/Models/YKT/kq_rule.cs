namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_rule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int wrkNo { get; set; }

        public int? wrkType { get; set; }

        public int? ciDao { get; set; }

        public int? zaoTui { get; set; }

        public int? validSignTime { get; set; }

        public int? weekHoliday { get; set; }

        [StringLength(5)]
        public string JB_startTime { get; set; }

        [StringLength(5)]
        public string JB_endTime { get; set; }

        public int? IsJBDCalc { get; set; }

        public int? IsHoliday { get; set; }

        public int? dayTimes { get; set; }
    }
}
