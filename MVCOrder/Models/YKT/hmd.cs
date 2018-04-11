namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hmd")]
    public partial class hmd
    {
        [Key]
        public int bh { get; set; }

        public int card_no { get; set; }

        public int? cust_no { get; set; }
    }
}
