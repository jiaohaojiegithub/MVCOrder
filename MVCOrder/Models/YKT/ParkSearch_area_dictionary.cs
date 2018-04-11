namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParkSearch_area_dictionary
    {
        [Key]
        [Column(Order = 0)]
        public int areaID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string areaName { get; set; }
    }
}
