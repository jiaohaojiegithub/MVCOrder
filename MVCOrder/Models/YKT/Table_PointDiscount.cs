namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_PointDiscount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string VipLevel { get; set; }

        [StringLength(50)]
        public string VipName { get; set; }

        public int? FreeTime { get; set; }

        public int? Point { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }
    }
}
