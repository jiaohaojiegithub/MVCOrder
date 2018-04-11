namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class car_type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int car_tid { get; set; }

        [StringLength(20)]
        public string car_tname { get; set; }
    }
}
