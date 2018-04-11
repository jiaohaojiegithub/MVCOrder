namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class color_type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int color_tid { get; set; }

        [StringLength(20)]
        public string color_tname { get; set; }
    }
}
