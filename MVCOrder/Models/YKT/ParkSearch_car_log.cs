namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParkSearch_car_log
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int devID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string devName { get; set; }

        public DateTime? DevTime { get; set; }

        public bool? devState { get; set; }
    }
}
