namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PA_tboScheme
    {
        [Key]
        public int SeqNO { get; set; }

        public int? Region { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        [StringLength(50)]
        public string Led { get; set; }

        [StringLength(50)]
        public string CaptureLayout { get; set; }

        public int? SchemeTime { get; set; }

        public int? RepeatTime { get; set; }

        public bool? OneCarMultipleNo { get; set; }

        public int? WaitTime { get; set; }

        public int park_no { get; set; }
    }
}
