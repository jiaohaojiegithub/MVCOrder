namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class car_no
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int car_tid { get; set; }

        [Column("car_no")]
        [StringLength(10)]
        public string car_no1 { get; set; }

        [StringLength(10)]
        public string car_name { get; set; }
    }
}
