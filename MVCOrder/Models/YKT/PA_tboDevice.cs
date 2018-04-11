namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PA_tboDevice
    {
        [Key]
        public int SeqNO { get; set; }

        public int? Region { get; set; }

        public int? UpNO { get; set; }

        [StringLength(50)]
        public string Display { get; set; }

        public int? DevType { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }
    }
}
