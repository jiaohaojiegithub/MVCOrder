namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stall_occuppy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stall { get; set; }

        public int? occuppy { get; set; }

        public int? isdown { get; set; }
    }
}
